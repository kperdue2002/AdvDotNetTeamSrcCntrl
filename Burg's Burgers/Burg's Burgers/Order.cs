using System;
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
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        
        // Start of Address Section
        
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$",
         ErrorMessage = "The input for the city is not valid.")]
        public string City { get; set; }

        [RegularExpression(@"^(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))$",
         ErrorMessage = "The input for a state needs to be the capitalized abbreviation.")]
        [Column(TypeName = "varchar")]
        public string State { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\d{5}$",
         ErrorMessage = "The zip code must be entirely made up of exactly 5 digits.")]
        [Column(TypeName = "varchar")]
        public string ZipCode { get; set; }

        // End of Address Section

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(1, 250)]
        public byte Quantity { get; set; }

        [StringLength(512)]
        [Column(TypeName = "nvarchar")]
        public string SpecialDirections { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateOfOrder { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }
    }
}
