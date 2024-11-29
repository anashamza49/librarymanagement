using biblio.Models;

namespace biblio.DTOs
{
    public class EmpruntDTO
    {
        public int Id { get; set; }
        public int LivreId { get; set; }
        public int AdherantId { get; set; }
    }
}
