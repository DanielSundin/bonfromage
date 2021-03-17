using System;
using System.ComponentModel.DataAnnotations;

namespace BonFromage.Models
{
    public class MenuItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
         [DataType(DataType.Currency)]
         public int Price { get; set; }
    }
}