using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartOutlet.Core.models
{
    public class Regulator
    {
        //Se crean las entidade de nuestra tabla regulator
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int status { get; set; }

        //Se pone el Icollection para que la otra clase encuentre la llave foranea que busca
        public virtual ICollection<User>Users{get; set;} 
    }
}