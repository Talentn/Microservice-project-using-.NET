using System.ComponentModel.DataAnnotations;

namespace FinalP.Web.Models
{
    public class EtudiantDto
    {
        public int EtudiantId { get; set; }
        
        public string EtudiantName { get; set; }
        
        public string Classename { get; set; }
        
        public int age { get; set; }
    }
}
