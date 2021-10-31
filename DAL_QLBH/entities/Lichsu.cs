using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH.entities
{
    [Table("LichSu")]
   public class Lichsu
   {
       [Key] 
       public int id { get; set; }
       [Required] 
       public string Email { get; set; }
       [Required]
      public DateTime Lucvao { get; set; }
       [Required]
       public DateTime Lucra { get; set; }
       public int Tinhtrang { get; set; }
   }
}
