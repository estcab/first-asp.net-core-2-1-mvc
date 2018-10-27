using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Tittle { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
