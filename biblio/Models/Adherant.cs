using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace biblio.Models
{
    public class Adherant
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Email { get; set; }
        public ICollection<Emprunt> Emprunts { get; set; }
    } 
}
