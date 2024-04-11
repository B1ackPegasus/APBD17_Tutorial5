namespace Application.Models;

public class Animal
    {
        public Animal(int id, string firstName, string category, double weight, string furColor)
        {
            Id = id;
            FirstName = firstName;
            Category = category;
            Weight = weight;
            FurColor = furColor;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Category { get; set; }
        public double Weight { get; set; }
        public string FurColor { get; set; }
    }
