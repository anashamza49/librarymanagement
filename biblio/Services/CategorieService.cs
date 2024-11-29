using AutoMapper;
using biblio.Data;
using biblio.DTOs;
using biblio.Models;
using biblio.Interfaces;

namespace biblio.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _myContext;
        public CategorieService(IMapper mapper, MyContext myContext)
        {
            _mapper = mapper;
            _myContext = myContext;
        }

        public IEnumerable<CategorieDTO> ListerCategorie()
        {
            var liste = _myContext.Categories.ToList();
            var listes = _mapper.Map<IEnumerable<CategorieDTO>>(liste);
            return listes;
        }

        public void AjouterCategorie(CategorieDTO categorie) 
        {
            var add = _mapper.Map<Categorie>(categorie);
            _myContext.Categories.Add(add);
            _myContext.SaveChanges();
        }
        public void ModifierCategorie(int id, CategorieDTO categorieDTO)
        {
            var oldcategorie = _myContext.Categories.FirstOrDefault(c => c.Id == id);
            if (oldcategorie == null)
            {
                throw new Exception("Categorie n'existe pas");
            }
            _mapper.Map(categorieDTO, oldcategorie);
            _myContext.SaveChanges();
        }
    }
}
