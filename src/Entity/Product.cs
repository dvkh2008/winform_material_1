using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SKCT.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string Description { get; set; }
    }
}
