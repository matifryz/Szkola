﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
namespace Szkola.Models
{
    
    public class Kurs
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdKurs { get; set; }
        [Required]
        [Display(Name ="Nazwa kursu")]
        [StringLength(20)]
        public string Nazwa { get; set; }
        [Required]
        [Display(Name ="Liczba studentów na kursie")]
        public int LStudentów { get; set; }
        public  virtual ICollection<OcenaKursu> OcenaKursu { get; set; }

    }
}