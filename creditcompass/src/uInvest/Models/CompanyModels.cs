using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace uInvest.Models
{
    public class CompanyContext : System.Data.Entity.DbContext 
    {
        public  CompanyContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<CompanyDto> Companies { get; set; }
    }

    [Table("Companies")]
    public class CompanyDto
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Published { get; set; }
        public string Path { get; set; }
        public string Version { get; set; }
    }
}