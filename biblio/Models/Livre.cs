﻿namespace biblio.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DatePublication { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public ICollection<Emprunt> Emprunts { get; set; }
    }
}
