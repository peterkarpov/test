﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        // Город проживания покупателя
        public City Location { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
