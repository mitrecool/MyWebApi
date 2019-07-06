using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models
{
    public class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PetId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }        
    }
}
