namespace VegasBoost.Models;

public class BreakfastController
{
    public Guid Id {get;}
    public string Name {get;}
    public string Description {get;}
    public DateTime StartDateTime {get;}    
    public DateTime EndDateTime {get;}
    public List<string> Savory {get;}
    public List<string> Sweet {get;}

    public BreakfastController(
        Guid id, 
        string name, 
        string description, 
        DateTime startDateTime, 
        DateTime endDateTime, 
        List<string> savory,
        List<string> sweet) 
    {
        this.Id = id;
        this.Name = name;s
        this.Description = description;
        this.StartDateTime = startDateTime;
        this.EndDateTime = endDateTime;
        this.Savory = savory;
        this.Sweet = sweet;
    }

}