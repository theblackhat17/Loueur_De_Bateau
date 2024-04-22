using System.Collections.Generic;

class BateauAMoteur : Bateau
{
    public BateauAMoteur()
    {
        CapaciteMax = 8;
        Inventaire = new List<string> { "gilets de sauvetage", "corne de brume", "extincteur" };
    }

    public override bool VerifierInventaire(List<string> inventaireRetour)
    {
        return Inventaire.Count == inventaireRetour.Count;
    }

    public override Itineraire SuggérerItinéraire()
    {
        return new Itineraire(
            "Exploration des îles",
            new List<string> { "Île Tortuga", "Île aux Perles", "Île du Crâne" }
        );
    }
}
