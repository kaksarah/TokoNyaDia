using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TokoNyaDia2.Entities
{
    [Table(name: "customer", Schema = "dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Customer Id")]
        // Customer : id, customerName, phoneNumber, address, email
        public int CustomerId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(100)")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Customer Phone")]
        public string CustomerPhone { get; set; }

        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }

        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        public override string ToString()
        {
            return $"{nameof(CustomerId)} : {CustomerId}, {nameof(CustomerName)} : {CustomerName}, {nameof(CustomerPhone)} : {CustomerPhone}, {nameof(CustomerAddress)} : {CustomerAddress}, {nameof(CustomerEmail)} : {CustomerEmail}";
        }

    }
}
