using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoNyaDia2
{
    [Table(name: "store", Schema = "dbo")]
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "store_id")]
        [Display(Name = "Store Id")]
        public int StoreId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(100)")]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }

        [Display(Name = "Store Address")]
        public string StoreAddress { get; set; }

        [Display(Name = "Store Phone")]
        public string StorePhone { get; set; }

        [Display(Name = "Siup Number")]
        public int SiupNumber { get; set; }
    }
}
