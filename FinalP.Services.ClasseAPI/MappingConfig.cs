using AutoMapper;
using FinalP.Services.ClasseAPI.Models;
using FinalP.Services.ClasseAPI.Models.Dto;

namespace FinalP.Services.ClasseAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EtudiantDto, Etudiant>();
                config.CreateMap<Etudiant, EtudiantDto>();
            });
            return mappingConfig;
        }
    }
}
