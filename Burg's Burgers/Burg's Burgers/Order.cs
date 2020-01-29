﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burg_s_Burgers
{
    class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        [Required]
        public CivicAddress DeliveryAddress { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public byte Quantity { get; set; }

        [Required]
        [StringLength(512)]
        [Column(TypeName = "varchar")]
        public string SpecialDirections { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateOfOrder { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }
    }
}