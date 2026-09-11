using CarNamespace;

namespace CarUtilitiesNamespace
{

 // Constructor initializes a new Car with a model and starting speed

    public static class CarUtilities
    {
        public static void Displaycar(Car car)
        {
            Console.WriteLine($"Model: {car.model}, Speed: {car.speed}");
        }
        
    }   
            
}
