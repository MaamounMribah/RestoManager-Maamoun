﻿using System.ComponentModel.DataAnnotations;

namespace RestoManager_Maamoun.Models.RestosModel
{
    public class Avis
    {
        public int CodeAvis { get; set; }
        public string NomPersonne { get; set; } = null!;
        [Range(1, 5)]
        public int Note { get; set; }
        public string Commentaire { get; set; } = null!;
        public int Numresto { get; set; }

        public virtual Restaurant? LeResto { get; set; }
    }
}
