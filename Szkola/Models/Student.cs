using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Szkola.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int IdStudent{ get; set; }
        
        public string ImieStudent  { get; set; }
        public string Nazwiskostudent { get; set; }
        
        public virtual ICollection<Nauczyciel> Nauczyciale{ get; set; }
    }
}