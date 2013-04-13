using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MEDMcKelvy.Models
{
    public class Technology
    {
        [Key]
        public int T_ID { get; set; }
        [Required]
        public string T_Name { get; set; }
        public string T_Desc { get; set; }
        public int T_QOH { get; set; }
        public string T_URL { get; set; }
    }
  
}