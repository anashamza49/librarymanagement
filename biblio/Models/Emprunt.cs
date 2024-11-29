namespace biblio.Models
{
    public class Emprunt
    {
        public int Id { get; set; }
        public int LivreId { get; set; }
        public Livre Livre { get; set; }
        public int AdherantId { get; set; }
        public Adherant Adherant { get; set; }
    }
}
