using FinalP.Web.Models;
using System;
using System.Threading.Tasks;

namespace FinalP.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto reponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
