using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace MEDMcKelvy.Models
{
    public class Supplies
    {
        [Key]
        public int S_ID { get; set; }
        [Required]
        public string S_Name { get; set; }
        public string S_Desc { get; set; }
        public int S_QOH { get; set; }
        public string S_URL { get; set; }
    }
    
    public class MEDMcKelvyDBContext : DbContext
    {
        public DbSet<Supplies> Supplies { get; set; }
        public DbSet<Technology> Technology { get; set; }

    }
}
