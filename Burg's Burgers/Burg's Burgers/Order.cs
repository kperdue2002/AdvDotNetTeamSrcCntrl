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
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "The first name input is too long.\n" +
                                         "The maximimum input is 50 characters.")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "The last name input is too long.\n" +
                                         "The maximimum input is 50 characters.")]
        public string LastName { get; set; }
        
        // Start of Address Section
        
        [Required(AllowEmptyStrings = false)]
        [StringLength(64, ErrorMessage = "The address input is too long.\n" +
                                         "The maximimum input is 64 characters.")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$",
         ErrorMessage = "The input for the city is not valid.")]
        [StringLength(32, ErrorMessage = "The city input is too long.\n" +
                                         "The maximimum input is 32 characters.")]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"^(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))$",
         ErrorMessage = "Please select a state.")]
        [Column(TypeName = "varchar")]
        [StringLength(2, ErrorMessage = "The state input is not abbreviated.\n" +
                                        "Please file this as an error to the developers.")]
        public string State { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\d{5}$",
         ErrorMessage = "The zip code must be made up of exactly 5 digits.")]
        [StringLength(5, ErrorMessage = "The zip code must be made up of exactly 5 digits.")]
        [Column(TypeName = "varchar")]
        public string ZipCode { get; set; }

        // End of Address Section

        [Phone]
        [Column(TypeName = "varchar")]
        [StringLength(16, ErrorMessage = "The phone number input is too long.\n" +
                                         "The maximimum input is 16 characters.")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(1, 250)]
        public byte Quantity { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(512, ErrorMessage = "The special directions input is too long.\n" +
                                          "The maximimum input is 512 characters.")]
        public string SpecialDirections { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateOfOrder { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }
    }
}
