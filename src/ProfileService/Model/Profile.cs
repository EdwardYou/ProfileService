using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Model
{
    public class Profile
    {
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Passion { get; set; }
        public string Ambition { get; set; }
    }
}
