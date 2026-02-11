using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TartuTouristGuide.Models
{
    public class Reward
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<string> RequiredPlaceIds { get; set; } = new List<string>();
        public string Category { get; set; } = string.Empty;
    }
}