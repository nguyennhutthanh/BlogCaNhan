using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogCaNhan.DTOs
{
    [Table("The Loai")]
    [Index("URL",IsUnique = true)]
   public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string TenTL { get; set; }
        [MaxLength(200)]
        public string URL { get; set; }
    }
}
