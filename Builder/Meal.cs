using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Meal : IMeal
    {
        public string Dessert { get; set; }
        public string Drinks { get; set; }
        public string Entree { get; set; }
        public string Mains { get; set; }
    }
}