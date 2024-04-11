using Application.Models;

namespace Application.Database;


public class StaticData
    {
        
        public static List<Animal> animals = new List<Animal>() {
            new Animal(1,"Asia","cat",6.300,"white"),
            new Animal(2,"Boby","dog",15.300,"black"),
            new Animal(3,"Andrei","rabbit",1.500,"brown"),
            new Animal(4,"Homa","Hamster",0.200,"Grey"),
        };
        
        public static List<Visit> visits = new List<Visit>() {
           new Visit(new DateTime(2024, 4, 10, 10, 0, 0), animals[0], "Routine checkup", 50.00),
           new Visit(new DateTime(2024, 4, 11, 14, 30, 0), animals[1], "Vaccination", 35.00),
           new Visit(new DateTime(2024, 4, 12, 11, 15, 0), animals[2], "Injury treatment", 80.00),
           new Visit(new DateTime(2024, 4, 13, 9, 45, 0), animals[3], "Dental cleaning", 60.00),

        };
    }
