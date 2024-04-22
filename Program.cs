using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue chez le loueur de bateaux !");
        Console.WriteLine("Choisissez votre type de bateau (1: Voile, 2: Moteur):");
        string choix = Console.ReadLine();
        Bateau bateau = null;

        switch (choix)
        {
            case "1":
                bateau = new BateauAVoile();
                break;
            case "2":
                bateau = new BateauAMoteur();
                break;
            default:
                Console.WriteLine("Choix invalide.");
                return;
        }

        Console.WriteLine("Entrez le nombre de passagers:");
        int nbPassagers = int.Parse(Console.ReadLine());
        if (!bateau.EmbarquerPassagers(nbPassagers))
        {
            Console.WriteLine("Trop de passagers pour ce type de bateau.");
            return;
        }

        Console.WriteLine("Souhaitez-vous ajouter des équipements supplémentaires ? (O/N)");
        string reponseEquipement = Console.ReadLine();
        if (reponseEquipement.ToUpper() == "O")
        {
            Console.WriteLine("Ajouter un moteur hors-bord pour 50€ ? (O/N)");
            if (Console.ReadLine().ToUpper() == "O")
            {
                bateau.AjouterEquipement(new Equipement("Moteur hors-bord", 50));
            }
            Console.WriteLine($"Le prix total de la location est maintenant de {bateau.CalculerPrixTotal()}€.");
        }

        Itineraire itineraire = bateau.SuggérerItinéraire();
        Console.WriteLine($"Itinéraire suggéré: {itineraire.Description}");
        Console.WriteLine("Lieux : " + string.Join(", ", itineraire.PointsInteret));

        Console.WriteLine("Avez-vous terminé votre excursion et tout aimé ? (O/N)");
        if (Console.ReadLine().ToUpper() == "O")
        {
            Console.WriteLine("Veuillez noter votre expérience sur 10 :");
            string note = Console.ReadLine();
            Console.WriteLine($"Merci pour votre note de {note}/10 ! Nous espérons vous revoir bientôt.");
        }

        Console.WriteLine("Bateau de retour. Vérification de l'inventaire...");
        List<string> inventaireRetour = bateau.Inventaire;
        if (bateau.VerifierInventaire(inventaireRetour))
        {
            Console.WriteLine("L'inventaire est complet.");
        }
        else
        {
            Console.WriteLine("Des éléments de l'inventaire manquent.");
        }
    }
}
