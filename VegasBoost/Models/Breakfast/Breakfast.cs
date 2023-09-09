namespace VegasBoost.Models;

public class Breakfast
{
    public Guid Id {get;}
    public string Name {get;}
    public string Description {get;}
    public DateTime? StartDateTime {get;}    
    public DateTime? EndDateTime {get;}
    public DateTime? LastModifiedDateTime {get;}
    public List<string> Savory {get;}
    public List<string> Sweet {get;}
    
    public Breakfast(
        Guid id, 
        string name, 
        string description, 
        DateTime? startDateTime, 
        DateTime? endDateTime, 
        DateTime? lastModifiedDateTime,
        List<string> savory,
        List<string> sweet) 
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.StartDateTime = startDateTime;
        this.EndDateTime = endDateTime;
        this.LastModifiedDateTime = lastModifiedDateTime;
        this.Savory = savory;
        this.Sweet = sweet;
    }

        // public Breakfast(Guid guid, string name, string description, DateTime? startDateTime, DateTime? endDateTime, DateTime utcNow, List<string> savory, List<string> sweet)
        // {
        //     Id = guid;
        //     Name = name;
        //     Description = description;
        //     StartDateTime1 = startDateTime;
        //     EndDateTime1 = endDateTime;
        //     UtcNow = utcNow;
        //     Savory = savory;
        //     Sweet = sweet;
        // }
}
