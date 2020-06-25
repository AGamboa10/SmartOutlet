using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartOutlet.Core.models
{
    public class User
    {
        //Se crean las entidade de nuestra tabla user
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(30, ErrorMessage = "Error")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Error")]
        public string NameUser { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "Error")]
        public string Password { get; set; }

        //Llaves foraneas
        public int IdRegulator{get; set;}
        public Regulator Regulator {get; set;}

    }
}