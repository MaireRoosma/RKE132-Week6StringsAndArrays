
string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway", "butter chicken" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight i am going to eat {snacks[randomIndex]} .");

