using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSansLogin.Models
{
    public class Article
    {
        public int Id { get; set; }
        [MaxLength(140)]
        public string Titre { get; set; }
        [Required]
        public string Corps { get; set; }

        public virtual ICollection<Commentaire> Commentaires { get; set; }
    }
}