using System.Collections.Generic;

class BateauAMoteur : Bateau
{
    public BateauAMoteur()
    {
        CapaciteMax = 8; // Ajustez selon les besoins spécifiques du bateau à moteur
        Inventaire = new List<string> { "gilets de sauvetage", "corne de brume", "extincteur" };
    }

    public override bool VerifierInventaire(List<string> inventaireRetour)
    {
        // Ici, vous pouvez implémenter une logique de vérification plus complexe si nécessaire
        return Inventaire.Count == inventaireRetour.Count;
    }

    public override Itineraire SuggérerItinéraire()
    {
        // Suggère un itinéraire spécifique pour les bateaux à moteur
        return new Itineraire(
            "Exploration des îles",
            new List<string> { "Île Tortuga", "Île aux Perles", "Île du Crâne" }
        );
    }
}
