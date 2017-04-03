using Microsoft.AspNetCore.Razor.TagHelpers;
using ProfileService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.TagHelpers
{
    [HtmlTargetElement("profile")]
    //[HtmlTargetElement(Attributes = "toony")]
    public class ProfiletagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            Profile myProfile = GetMyProfile();

            string html = string.Empty;
            html += "<table border=1px><tr><th>Picture</th><th>Name</th></th><th>Passion</th></th><th>Ambition</th></tr>";
            string photo = "\"/images/eyou.jpg\"";
            html += "<tr>";
            html += "<td><img src=" + photo + " style='width: 50px' /></td>";
            html += "<td>" + myProfile.Name + "</td>";
            html += "<td>" + myProfile.Passion + "</td>";
            html += "<td>" + myProfile.Ambition + "</td>";
            html += "</tr>";
            html += "</table>";

            output.Content.SetHtmlContent(html);
        }

        private Profile GetMyProfile()
        {
            Profile myProfile = new Profile()
            {
                Name = "Edward You",
                PlaceOfBirth = "Kwang-Ju Seoul, Korea",
                Passion = "I might not be the smartest one, but I am hard working person!",
                Ambition = "I want to be a famouse DataBase Admin in BC!"
            };

            return myProfile;
        }
    }
}
