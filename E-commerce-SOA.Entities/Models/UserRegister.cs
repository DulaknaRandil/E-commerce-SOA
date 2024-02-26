using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.Entities.Models
{
    public class UserRegister
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string UserPassword {  get; set; }
        [Column(TypeName = "VARCHAR(50)")]

        public string UserEmail { get; set; }

    }
}
