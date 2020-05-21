using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public class Country : IEntity
    {
        public long Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CountryName { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string CountryCode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
