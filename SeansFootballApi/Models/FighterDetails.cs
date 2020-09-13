using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeansFootballApi.Models
{
    
    public class FighterDetails
    {
        //Setting the primary key
        
        private string Name { get; set; }
        private int Age { get; set; }
        private int Weight { get; set; }
        private int Reach { get; set; }
        private int Height { get; set; }
        private int Wins { get; set; }
        private int Losses { get; set; }

    }
}
