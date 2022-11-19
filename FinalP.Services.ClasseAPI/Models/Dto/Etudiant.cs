using System.ComponentModel.DataAnnotations;

namespace FinalP.Services.ClasseAPI.Models.Dto
{
    public class Etudiant
    {
        [Key]
        public int EtudiantId { get; set; }
        [Required]
        public string EtudiantName { get; set; }
        [Required]
        public string Classename { get; set; }
        [Range(18, 27)]
        public int age { get; set; }



    }
}
