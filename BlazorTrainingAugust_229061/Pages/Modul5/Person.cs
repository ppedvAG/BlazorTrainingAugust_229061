using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace BlazorTrainingAugust_229061.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(15,ErrorMessage ="max 15 zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(140,190,ErrorMessage ="zwischen 140 und 190cm")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
    }
}
