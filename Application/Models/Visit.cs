namespace Application.Models;

public class Visit
{
    
    public Visit(DateTime dateTime,Animal animal,String description,double price)
    {
        datetimeVisit = dateTime;
        animale = animal;
        text = description;
        priceVisit = price;
    }

    public DateTime datetimeVisit { get; set; }
    public Animal animale { get; set; }
    public String text { get; set; }
    public double priceVisit { get; set;}
}