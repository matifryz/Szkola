using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Szkola.Models
{
    
    public class Kurs
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdKurs { get; set; }
        public string Nazwa { get; set; }
        public int LStudentów { get; set; }
        public  virtual ICollection<Nauczyciel> Nauczyciele { get; set; }

    }
}