﻿using Mastodon.Slider.Models;

namespace Mastodon_API.Responses
{

    public interface ISliderCSS
    {
        string GetSliderCSS(ClientsWebsite clientWebsiteData);
    }

    public class SliderCSS : ISliderCSS
    {
        public string GetSliderCSS(ClientsWebsite clientWebsiteData)
        {

            //todo implement custom user settings for CSS here...color, fonts....stuff.

            //build form SliderCSS.css
            return ".slickFont{font-family: Helvetica;}#slickSlider{right: 0px; position: fixed; top: 50px; z-index: 10;}#slickImageMessage{position: absolute; right: 0px; top: 100px;}#slickImage{position: absolute; box-shadow: 0 0 8px gray; right: 0px; top: 150px; cursor: pointer;}#slickContactForm{position: absolute; width: 300px; height: 450px; right: 0; border: 1px solid #d8d8d8; margin-left: 40px; padding: 20px 40px; border-radius: 3px; box-shadow: 0 0 8px gray; visibility: hidden; background-color: white;}.slickInputBox input[type='text']{padding: 10px; margin-left: -10px; width: 250px; border: none; border-bottom: solid 2px #c9c9c9; transition: border 0.3s;}.slickInputBox input[type='text']:focus, .slickInputBox input[type='text'].focus{border-bottom: solid 4px #c9c9c9;}.Fixed{position: fixed; top: 20px;}.button{background-color: #4CAF50; /* Green */ border: none; color: white; padding: 8px 20px; text-align: center; text-decoration: none; display: inline-block; font-size: 16px;}.userInputTextArea{resize: none; height: 100px; width: 240px;}";
        }
    }
}