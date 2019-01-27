using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szkola.Models
{
    public enum Ocena
    {
        dwa, trzy, cztery, pięć
    }
    public class Nauczyciel
    {
        [Key]
        [Required]
        public long IdNauczyciel { get; set; }
        
        public int IdKurs { get; set; }
        
        public int IdStudent { get; set; }
        public Ocena? Ocena { get; set; }

        public virtual Kurs Kurs { get; set; }
        public virtual Student Student { get; set; }
    }
}