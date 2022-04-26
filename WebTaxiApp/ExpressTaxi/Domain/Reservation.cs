﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressTaxi.Domain
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Passengers { get; set; }
        public int TaxiId { get; set; }
        public virtual Taxi Taxi { get; set; }
        public string TaxiUserId { get; set; }
        public virtual TaxiUser TaxiUser { get; set; }
        public string Status { get; set; }
        public int OptionId { get; set; }
        public virtual Option Option { get; set; }
    }
}