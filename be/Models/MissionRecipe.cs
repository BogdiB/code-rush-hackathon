// Models/MissionRecipe.cs
using System.Collections.Generic;

namespace Backend.Models
{
    public class MissionRecipe
    {
        public string Title { get; set; } = string.Empty;
        public string Risks { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        // Time in minutes
        public int EstimatedTimeMinutes { get; set; } 
        
        public List<string> Equipment { get; set; } = new List<string>(); 
        public List<string> Instructions { get; set; } = new List<string>(); 

        public string Status { get; set; } = "ACTIV";
        public string Warning { get; set; } = "Acest fișier se va autodistruge în 5... 4... 3... 2...";
    }
}