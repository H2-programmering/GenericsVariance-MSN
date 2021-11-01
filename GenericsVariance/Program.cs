using System;
using GenericsVariance.Animals;
using GenericsVariance.Collections;

namespace GenericsVariance
{
    class Program
    {
        static void Main(string[] args)
        {
            // No problem, since Collection implements 
            // ICollectionGet and ICollectionSet
            Collection<Bird> birds = new Collection<Bird>();
            ICollectionGet<Bird> birdsGet = birds;
            ICollectionSet<Bird> birdsSet = birds;
            //ICollection<Bird> birdsGet = birds;
            //ICollection<Bird> birdsSet = birds;

            // No problem, since Collection implements 
            // ICollectionGet and ICollectionSet
            Collection<Animal> animals = new Collection<Animal>();
            ICollectionGet<Animal> animalsGet = animals;
            ICollectionSet<Animal> animalsSet = animals;
            //ICollection<Animal> animalsGet = animals;
            //ICollection<Animal> animalsSet = animals;


            AnimalProcessor processor = new AnimalProcessor();

            // Sources:
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/

            // Notes:
            // Covariance <out T>: T can only be returned, but not used as method parameter type.
            // Contravariance <int T>: T can only be used as parameter type, but not as return type.

            // How many of these work...?

            // Answers:
            // 4. B, C, F, G
            // 7. A
            // 9. H
            // 10. Replace "Bird.Flap() and Cat.Purr() with abstract Animal.Action() and override in child classes
            // 11.

            Console.WriteLine("Processing animals...");

            processor.ProcessAnimals(birdsGet);   // Case A
            processor.ProcessAnimals(animalsGet); // Case B

            processor.ProcessBirds(birdsGet);     // Case C
            processor.ProcessBirds(animalsGet);   // Case D
            
            Console.WriteLine("Inserting animals...");

            //processor.InsertAnimals(birdsSet);    // Case E <-- Can't make this work!
            processor.InsertAnimals(animalsSet);  // Case F

            processor.InsertBirds(birdsSet);      // Case G
            processor.InsertBirds(animalsSet);    // Case H

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
