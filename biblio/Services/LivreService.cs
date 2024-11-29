using AutoMapper;
using biblio.Data;
using biblio.DTOs;
using biblio.Interfaces;
using biblio.Models;

namespace biblio.Services
{
    public class LivreService : ILivreService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public LivreService(MyContext context, IMapper mapper) 
        { 
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<LivreDTO> ListerLivres()
        {
            var livres = _context.Livres.ToList();
            var livresDTO = _mapper.Map<IEnumerable<LivreDTO>>(livres);
            return livresDTO;
        }
        public void AjouterLivre(LivreDTO livreDTO)
        {
            var livre = _mapper.Map<Livre>(livreDTO);
            _context.Add(livre);
            _context.SaveChanges();
        }
        public void ModifierLivre(int id, LivreDTO livreDTO)
        {
            var livre = _context.Livres.FirstOrDefault(l => l.Id == id);
            if (livre == null) 
            {
                throw new Exception("Le livre n'existe pas");
            }
            _mapper.Map(livreDTO, livre);
            _context.SaveChanges();
        }
    }
}
