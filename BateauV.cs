using System.Collections.Generic;

class BateauAVoile : Bateau
{
    public BateauAVoile()
    {
        CapaciteMax = 4;
        Inventaire = new List<string> { "voiles", "cordes", "boussole" };
    }

    public override bool VerifierInventaire(List<string> inventaireRetour)
    {
        return Inventaire.Count == inventaireRetour.Count;
    }

    public override Itineraire SuggérerItinéraire()
    {
        return new Itineraire(
            "Parcours côtier classique",
            new List<string> { "Baie de Sunshine", "Cap des Dauphins", "Plage des Étoiles" }
        );
    }
}
