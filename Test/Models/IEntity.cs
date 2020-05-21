using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public interface IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long Id { get; set; }

        DateTime DateAdded { get; set; }

        DateTime DateModified { get; set; }
    }
}
