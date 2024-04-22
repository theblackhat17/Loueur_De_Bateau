public class Equipement
{
    public string Nom { get; set; }
    public decimal Prix { get; set; }

    public Equipement(string nom, decimal prix)
    {
        Nom = nom;
        Prix = prix;
    }
}
