namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa djur med standardvärden.
            Dog dog = new Dog();
            Cat cat = new Cat();
            Snake snake = new Snake();
            Bulldog bulldog = new Bulldog();
            Chihuahua chihuahua = new Chihuahua();
            Human human = new Human();

            // Skapa en hund med egna värden.
            Dog anotherDog = new Dog(
                "Rex", 6, 30, "Svart", false, "Schäfer");

            // Alla dessa objekt är också Animal genom arv.
            Animal[] animals =
            {
                dog,
                cat,
                snake,
                bulldog,
                chihuahua,
                human,
                anotherDog
            };

            // Gå igenom alla djur i arrayen.
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Namn: {animal.Name}");
                Console.WriteLine($"Ålder: {animal.Age}");
                Console.WriteLine($"Vikt: {animal.Weight} kg");
                Console.WriteLine($"Färg: {animal.Color}");

                // Skilj mellan vilda och tama djur.
                if (animal.IsWild)
                {
                    Console.WriteLine("Kategori: Vilt djur");
                }
                else
                {
                    Console.WriteLine("Kategori: Tamt djur");
                }

                // Skilj mellan däggdjur och reptiler.
                if (animal is Mammal)
                {
                    Console.WriteLine("Djurgrupp: Däggdjur");
                }
                else if (animal is Reptile)
                {
                    Console.WriteLine("Djurgrupp: Reptil");
                }

                // Polymorfism: varje djur använder sitt eget ljud.
                animal.makeSound();

                // Metoderna ärvs från Animal.
                animal.Eat();
                animal.Sleep();

                Console.WriteLine();
            }

            // Visa djurens egna egenskaper och metoder.
            Console.WriteLine($"Hundras: {dog.Breed}");
            dog.Fetch();

            Console.WriteLine($"Gillar att klättra: {cat.LikesClimbing}");
            cat.Climb();

            Console.WriteLine($"Giftig: {snake.IsVenomous}");
            snake.Crawl();

            Console.WriteLine($"Har rynkor: {bulldog.HasWrinkles}");
            bulldog.Snore();

            Console.WriteLine($"Fryser lätt: {chihuahua.GetsColdEasily}");
            chihuahua.Shiver();

            Console.WriteLine($"Språk: {human.Language}");
            human.Speak();

            Console.WriteLine();

            // Anropa metoder som ärvs från djurgrupperna.
            dog.FeedMilk();
            snake.BaskInSun();

            Console.WriteLine();

            // Skapa en växt.
            Plant plant = new Plant();

            Console.WriteLine($"Växt: {plant.Name}");
            Console.WriteLine($"Höjd: {plant.Height} meter");

            // Grow ärvs från LivingOrganism.
            plant.Grow();
            plant.Photosynthesize();
        }
    }
}