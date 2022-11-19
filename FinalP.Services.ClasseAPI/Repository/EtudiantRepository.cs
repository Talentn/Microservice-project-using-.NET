using AutoMapper;
using FinalP.Services.ClasseAPI.DbContexts;
using FinalP.Services.ClasseAPI.Models;
using FinalP.Services.ClasseAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalP.Services.ClasseAPI.Repository
{
    public class EtudiantRepository : IClasseRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public EtudiantRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<EtudiantDto> CreateUpdateEtudiant(EtudiantDto etudiantDto)
        {
            Etudiant etudiant = _mapper.Map<EtudiantDto, Etudiant>(etudiantDto);
            if (etudiant.EtudiantId > 0)
            {
                _db.Etudiants.Update(etudiant);
            }
            else
            {
                _db.Etudiants.Add(etudiant);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Etudiant, EtudiantDto>(etudiant); 
        }

        public async Task<bool> DeleteEtudiant(int etudiantId)
        {
            try
            {
                Etudiant etudiant = await _db.Etudiants.FirstOrDefaultAsync(u => u.EtudiantId == etudiantId);
                if (etudiant == null)
                {
                    return false;
                }
                _db.Etudiants.Remove(etudiant);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<EtudiantDto> GetEtudiantById(int etudiantId)
        {
            Etudiant etudiant = await _db.Etudiants.Where(x=>x.EtudiantId==etudiantId).FirstOrDefaultAsync();
            return _mapper.Map<EtudiantDto>(etudiant);
        }

        public async Task<IEnumerable<EtudiantDto>> GetEtudiants()
        {
            List<Etudiant> ListEtudiant = await _db.Etudiants.ToListAsync();
            return _mapper.Map<List<EtudiantDto>>(ListEtudiant);
        }
    }
}
