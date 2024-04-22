using System.Collections.Generic;

public class Itineraire
{
    public string Description { get; set; }
    public List<string> PointsInteret { get; set; }

    public Itineraire(string description, List<string> pointsInteret)
    {
        Description = description;
        PointsInteret = pointsInteret;
    }
}
