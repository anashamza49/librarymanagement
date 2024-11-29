namespace biblio.DTOs
{
    public class LivreDTO
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DatePublication { get; set; }
        public int CategorieId { get; set; }
    }
}
