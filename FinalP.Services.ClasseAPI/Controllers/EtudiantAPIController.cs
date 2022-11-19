using FinalP.Services.ClasseAPI.Models;
using FinalP.Services.ClasseAPI.Models.Dto;
using FinalP.Services.ClasseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace FinalP.Services.ClasseAPI.Controllers
{
    [Route("api/etudiants")]
    public class EtudiantAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IClasseRepository _classeRepository;
        public EtudiantAPIController(IClasseRepository classeRepository)
        {
            _classeRepository = classeRepository;
            this._response = new ResponseDto();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<EtudiantDto> etudiantDtos = await _classeRepository.GetEtudiants();
                _response.Result = etudiantDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                IEnumerable<EtudiantDto> etudiantDtos = await _classeRepository.GetEtudiants();
                _response.Result = etudiantDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
                public async Task<object> Post([FromBody] EtudiantDto etudiantDto)
        {
            try
            {
                EtudiantDto model = await _classeRepository.CreateUpdateEtudiant(etudiantDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpPut]
        public async Task<object> put([FromBody] EtudiantDto etudiantDto)
        {
            try
            {
                EtudiantDto model = await _classeRepository.CreateUpdateEtudiant(etudiantDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool IsSuccess = await _classeRepository.DeleteEtudiant(id);
                _response.Result = IsSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
