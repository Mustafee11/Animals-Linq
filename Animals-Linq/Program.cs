namespace Animals_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Animals = new List<Animals>()
           {
               new Animals {Name = "Bertil" , Age = 21 , Vaccinated = "No" , Legs = 4 , Species = "Dog"},
               new Animals {Name = "Larson" , Age = 12 , Vaccinated = "Yes" , Legs = 4 , Species = "Cat"},
               new Animals {Name = "Matilda" , Age = 4 , Vaccinated = "Yes" , Legs = 0 , Species = "Goldfish"},
               new Animals {Name = "Max" , Age = 10 , Vaccinated = "No" , Legs = 4 , Species = "Cow"},
               new Animals {Name = "Jeff" , Age = 26 , Vaccinated = "no" , Legs = 4 , Species = "Horse"},
               new Animals {Name = "Daisy" , Age = 14 , Vaccinated = "No" , Legs = 4 , Species = "Rabbit"},
               new Animals {Name = "Shadow" , Age = 5 , Vaccinated = "Yes" , Legs = 4 , Species = "Horse"},
               new Animals {Name = "Buddy" , Age = 2 , Vaccinated = "No" , Legs = 4 , Species = "Dog"},
               new Animals {Name = "Luna" , Age = 3 , Vaccinated = "No" , Legs = 4 , Species = "Cat"},
               new Animals {Name = "Eric" , Age = 1 , Vaccinated = "No" , Legs = 4 , Species = "Parrot"},
               new Animals {Name = "Kalson" , Age = 21 , Vaccinated = "No" , Legs = 4 , Species = "Rabbit"}

           };

            //1 Hur många hundar finns det (1 Siffra)

            var HowManyDogsIsThere = Animals.Count(n => n.Species == "Dog");

            Console.WriteLine($"Number of Dogs: {HowManyDogsIsThere} ");

            //2 Äldsta djuret (1 Animal)

           var OldestAge = Animals.Max(o => o.Age);

            var OldestAnimal = Animals.FirstOrDefault(o => o.Age == OldestAge);

            Console.WriteLine($"Animal: {OldestAnimal.Species} , Age: {OldestAge}");



            //3 Vaccinerade djur (List)

            var VaccinatedAnimals = Animals.Where(o => o.Vaccinated == "Yes").ToList();


            foreach (var item in VaccinatedAnimals)
            {
                Console.WriteLine($"Name: {item.Name} , species: {item.Species} , Vaccinated: {item.Vaccinated}");
            }

            Console.WriteLine("--------------------");

            //4 4 ben över 3 år gamla (List) ​

            var FourlegsOver3YearsOld = Animals.Where(o => o.Legs == 4 && o.Age > 3).ToList();


            foreach (var item in FourlegsOver3YearsOld)
            {
                Console.WriteLine($"Name: {item.Name} , Species: {item.Species} , Legs: {item.Legs} , Age: {item.Age} ");
            }

            Console.WriteLine("--------------------");

            //5 Finns ett djur som heter Shadow (Bool)​

            var IsThereAnyNamedShadow = Animals.Any( a => a.Name == "Shadow");

            Console.WriteLine(IsThereAnyNamedShadow);





        }
    }
}
