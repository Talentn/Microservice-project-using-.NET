using System.ComponentModel.DataAnnotations;

namespace FinalP.Services.ClasseAPI.Models
{
    public class EtudiantDto
    {
        public int EtudiantId { get; set; }
        
        public string EtudiantName { get; set; }
        
        public string Classename { get; set; }
        
        public int age { get; set; }
    }
}
