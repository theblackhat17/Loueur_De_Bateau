using System.Collections.Generic;
using System.Linq;

abstract class Bateau
{
    public int CapaciteMax { get; protected set; }
    public List<string> Inventaire { get; protected set; }
    public List<Equipement> EquipementsSupplementaires { get; set; } = new List<Equipement>();

    public abstract bool VerifierInventaire(List<string> inventaireRetour);

    public bool EmbarquerPassagers(int nombrePassagers)
    {
        return nombrePassagers <= CapaciteMax;
    }

    public decimal CalculerPrixTotal()
    {
        decimal prixBase = 100;
        return prixBase + EquipementsSupplementaires.Sum(e => e.Prix);
    }

    public void AjouterEquipement(Equipement equipement)
    {
        EquipementsSupplementaires.Add(equipement);
    }

    public abstract Itineraire SuggérerItinéraire();
}
