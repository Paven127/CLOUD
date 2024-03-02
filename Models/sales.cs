﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Undisclosed_Shop.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SaleId { get; set; }
        public string SaleDate { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }

        public bool Complete { get; set; }

        public Sale()
        {
            this.Complete = false;
        }


        public ApplicationUser ApplicationUser { get; set; }


        [NotMapped]
        public RegisterViewModel model { get; set; }
        public double? SaleTotal { get; set; }


        [NotMapped]

        public List<SaleDetail> SaleDetails { get; set; }

        public string OrderStatus { get; set; }


    }
}
