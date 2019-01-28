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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdStudent{ get; set; }
        [Required]
        [StringLength(10, MinimumLength =1)]
        [Display(Name ="Imie")]
        public string ImieStudent  { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="Nie więcej niż 10 liter")]
        [Column("Nazwisko")]
        [Display(Name ="Nazwisko")]
        public string Nazwiskostudent { get; set; }
        
        [Display(Name ="Imie i nazawisko")]
        public string Nazwa
        {
            get
            {
                return ImieStudent + " " + Nazwiskostudent;
            }
        }
        public virtual ICollection<OcenaKursu> OcenaKursu{ get; set; }
    }
}