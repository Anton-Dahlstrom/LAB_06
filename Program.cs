namespace LAB_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> { 
                new Cat(),
                new Snake(),
                new Dog(),
                new Bulldog(),
                new Husky()
            };
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
