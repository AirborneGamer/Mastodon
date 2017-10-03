﻿using Mastodon.Slider.Models;

namespace Mastodon_API.Responses.HTML
{

    public interface IBasicHTML
    {
        string getSliderHTML(ClientsWebsite clientWebsiteData);
    }

    public class BasicHTML : IBasicHTML
    {
        public string getSliderHTML(ClientsWebsite clientWebsiteData)
        {
            //user clientWebsiteData.stuff....
            //build form SliderHTML.html
            return "<img id='slickImage' onclick='slickSliderClicked()'/><div id='slickContactForm' class='slickFont'> <h2>Contact Form</h2> <p>This is my form.Please fill it out.It's awesome!</p><div class='slickInputBox'> <input type='text' placeholder='Your Name'> </div><div class='slickInputBox'> <input type='text' placeholder='Your Email'> </div><div> <textarea class='userInputTextArea'>Message</textarea> </div><div> <button class='button button1'>Send Message</button> </div></div>";
        }
    }
}