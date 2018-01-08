﻿using OsOEasy.Data;
using OsOEasy.Models;
using OsOEasy.Models.DBModels;
using OsOEasy.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Collections.Generic;

namespace OsOEasy.Controllers.Promo
{
    [Area("Promotion")]
    public class CreatePromoController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly ICommon _common;

        public CreatePromoController(ApplicationDbContext dbContext, ICommon common)
        {
            _dbContext = dbContext;
            _common = common;
        }

        public async Task<IActionResult> CreateNewPromo(string promoId)
        {
            var user = await _common.GetCurrentUserAsync(HttpContext);
            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }

            HttpContext.Session.SetString("promoId", (String.IsNullOrEmpty(promoId) ? "" : promoId));

            return View();
        }

        [HttpGet]
        public JsonResult GetPromoData()
        {
            Promotion promoModel = GetPromoModel(HttpContext.Session.GetString("promoId"));
            return Json(promoModel);
        }

        public Promotion GetPromoModel(string promoId)
        {
            var promo = new Promotion();

            if (!String.IsNullOrEmpty(promoId))
            {
                //Edit existing promtion
                promo = (from x in _dbContext.Promotion where x.Id == promoId select x).FirstOrDefault();
                //HttpContext.Session.SetInt32("activePromo", Convert.ToInt32(promo.ActivePromotion));
            }

            return promo;
        }

        [HttpGet]
        public JsonResult GetPromoImages(string imageType)
        {
            IFileProvider provider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
            IDirectoryContents contents = provider.GetDirectoryContents("wwwroot/images/Slider/" + imageType);

            List<string> imageItems = new List<string>();
            foreach (IFileInfo item in contents)
            {
                imageItems.Add(item.Name);
            }

            return Json(imageItems);
        }

        //todo [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> SaveNewPromo([FromBody]Promotion promoItem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (_dbContext)
                    {
                        promoItem.CreationDate = DateTime.Now;
                        if (!string.IsNullOrEmpty(promoItem.Id))
                        {
                            //Update existing promtion
                            //promoItem.ActivePromotion = Convert.ToBoolean(HttpContext.Session.GetInt32("activePromo"));
                            _dbContext.Entry(_dbContext.Promotion.Find(promoItem.Id)).CurrentValues.SetValues(promoItem);
                        }
                        else
                        {
                            //Creat new promotion
                            ApplicationUser appUser = await _common.GetCurrentUserAsync(HttpContext);
                            promoItem.ApplicationUser = appUser;
                            _dbContext.Promotion.Add(promoItem);
                        }

                        _dbContext.SaveChanges();
                    }
                }
                else
                {
                    //todo log that user is trying to bypass UI JS validation
                }
            }
            catch (Exception ex)
            {
                //todo handle exception
            }

            return RedirectToAction("Dashboard", "Dashboard", new { area = "Dashboard" });
        }

        [HttpGet]
        public void DeletePromo(string promoId)
        {
            using (_dbContext)
            {
                var promoToDelete = _dbContext.Promotion.Where(c => c.Id == promoId).FirstOrDefault();
                _dbContext.Remove(promoToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}