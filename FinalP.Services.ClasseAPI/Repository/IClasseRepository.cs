using FinalP.Services.ClasseAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalP.Services.ClasseAPI.Repository
{
    public interface IClasseRepository
    {
        Task<IEnumerable<EtudiantDto>> GetEtudiants();
        Task<EtudiantDto> GetEtudiantById(int etudiantId);
        Task<EtudiantDto> CreateUpdateEtudiant(EtudiantDto etudiantDto);
        Task<bool> DeleteEtudiant(int etudiantId);
    }
}
