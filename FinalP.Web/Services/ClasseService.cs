using FinalP.Web.Models;
using FinalP.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinalP.Web.Services
{
    public class ClasseService : BaseService, IClasseService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ClasseService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> CreateEtudiantAsync<T>(EtudiantDto etudiantDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = etudiantDto,
                Url = SD.ClasseAPIBase + "/api/etudiants/",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteEtudiantAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ClasseAPIBase + "/api/etudiants/" + id,
                AccessToken = ""
            });
        }


        public async Task<T> GetAllEtudiantsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,

                Url = SD.ClasseAPIBase + "/api/etudiants/",
                AccessToken = ""
            });
        }


        public async Task<T> GetEtudiantByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,

                Url = SD.ClasseAPIBase + "/api/etudiants" + id,
                AccessToken = ""
            });
        }


        public async Task<T> UpdateEtudiantAsync<T>(EtudiantDto etudiantDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = etudiantDto,
                Url = SD.ClasseAPIBase + "/api/etudiants",
                AccessToken = ""
            });

        }

    }
}
    

