using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TartuTouristGuide.Models
{
    public class Place
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Hours { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}