using FinalP.Web.Models;
using System.Threading.Tasks;

namespace FinalP.Web.Services.IServices
{
    public interface IClasseService
    {
        Task<T> GetAllEtudiantsAsync<T>();
        Task<T> GetEtudiantByIdAsync<T>(int id);
        Task<T> CreateEtudiantAsync<T>(EtudiantDto etudiantDto);
        Task<T> UpdateEtudiantAsync<T>(EtudiantDto etudiantDto);
        Task<T> DeleteEtudiantAsync<T>(int id);


    }
}
