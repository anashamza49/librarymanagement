using AutoMapper;
using biblio.DTOs;
using biblio.Models;
namespace biblio.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<LivreDTO,Livre>();
            CreateMap<CategorieDTO, Categorie>();
            CreateMap<AdherantDTO, Adherant>();
            CreateMap<EmpruntDTO, Emprunt>();
        }
    }
}
