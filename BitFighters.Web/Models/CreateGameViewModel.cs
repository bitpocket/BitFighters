using Game;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BitFighters.Web.Models
{
    public class CreateGameViewModel
    {
        [Required]
        [Display(Name = "Game name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Game type")]
        public string GameType { get; set; }

        public IEnumerable<IGameHeader> GameTypes { get; set; }
    }
}