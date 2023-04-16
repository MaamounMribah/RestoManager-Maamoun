namespace RestoManager_Maamoun.Models.RestosModel
{
    public class Restaurant
    {
        public int CodeResto { get; set; }
        public string NomResto { get; set; } = null!;
        public string Specialite { get; set; } = null!;

        public string Ville { get; set; } = null!;
        public string Tel { get; set; } = null!;

        public int NumProp { get; set; }
        public virtual Proprietaire? LeProprio { get; set; }
        public virtual ICollection<Avis>? LesAvis { get; set; }
    }
}
