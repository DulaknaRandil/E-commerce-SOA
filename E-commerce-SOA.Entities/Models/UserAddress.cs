using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.Entities.Models
{
    public class UserAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string BillingAddress { get; set; }
        [Column(TypeName = "VARCHAR(Max)")]
        public string DeliveryAddress { get; set; }
         
    }
}
