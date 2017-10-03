﻿using Mastodon.Slider.Models;

namespace Mastodon_API.Responses.CSS
{

    public interface IBasicCSS
    {
        string GetSliderCSS(ClientsWebsite clientWebsiteData);
    }

    public class BasicCSS : IBasicCSS
    {
        public string GetSliderCSS(ClientsWebsite clientWebsiteData)
        {

            //todo implement custom user settings for CSS here...color, fonts....stuff.

            //build form SliderCSS.css
            return ".slickFont{font-family: Helvetica;}#sliderContainer{position: fixed; z-index: 10; right: 0px; top: 10%;}#slickImage{position: relative; box-shadow: 0 0 8px gray; margin-top: 15%; cursor: pointer; float: right;}#slickContactForm{position: relative; right: 0; max-width: 250px; border: 1px solid #d8d8d8; padding: 10px 20px; /*border-radius: 5px; ...for rounded edges...*/ /*todo Adjust this for user*/ box-shadow: 5px 0 50px gray; /*todo Adjust this for user*/ visibility: hidden; background-color: white; /*todo Adjust this for user*/ float: right;}.slickInputBox input[type='text']{padding: 5px; border-bottom: solid 2px #c9c9c9; transition: border 0.5s; width: 95%}.slickInputBox input[type='text']:focus, .slickInputBox input[type='text'].focus{border-bottom: solid 2px #c9c9c9;}.userInputTextArea{resize: none; height: 50px; width: 95%;}.button{background-color: #4CAF50; /* Green */ border: none; color: white; padding: 5% 5%; font-size: 100%;}";
        }
    }
}