using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Uppgift1.Models
{
    public class QuizViewModel
    {
        [Required(ErrorMessage = "Skriv ditt namn")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Skriv din ålder")]
        [Range(13, 99, ErrorMessage = "Ålder mellan 13 och 99 år")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Välj din favoritårstid")]
        public string FavoriteSeason { get; set; }

        [Required(ErrorMessage = "Välj ditt favoritgodis")]
        public string FavoriteCandy { get; set; }

        public string[] SeasonList = { "Vår", "Sommar", "Höst", "Vinter"};
        public string[] CandyList = { "Center", "Colaflaskor", "Plopp", "Gelehallon" };
    }
}