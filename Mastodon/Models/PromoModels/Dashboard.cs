﻿using System;
using System.Collections.Generic;

namespace OsOEasy.Models.PromoModels
{
    [Serializable]
    public class Dashboard
    {
        //Account
        public string CurrentSubscription { get; set; }
        public string DashboardMessage { get; set; }
        public bool AccountWarning { get; set; }

        //Entries
        public string ActivePromoId { get; set; }
        public string ActivePromoName { get; set; }
        public bool IsActivePromo { get; set; }
        public string ActivePromoDiscount { get; set; }
        public string ActivePromoScript { get; set; }
        public int ActivePromoClaimedEntries { get; set; }
        public int ActivePromoViews { get; set; }
        public string ActivePromoEndDate { get; set; }
        public string ActivePromoWarningMessage { get; set; }
        public string ActivePromoType { get; set; }
        public List<InactivePromos> InactivePromos { get; set; }
    }

    public class InactivePromos
    {
        public string PromoId;
        public string PromoName;
        public string PromoDiscount;
        public string PromoType;
    }
}