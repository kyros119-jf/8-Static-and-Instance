using CarNamespace;
using CarUtilitiesNamespace;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the car model from the user
            Console.WriteLine("Please enter the model of the car:");
            string modelName = Console.ReadLine() ?? "";
        
         // Create one Car instance
            Car myCar = new Car(modelName);
        
            // Change the Car's state and display the updated information
            myCar.Accelerate();
            CarUtilities.Displaycar(myCar);

            myCar.Accelerate();
            CarUtilities.Displaycar(myCar);
            
            myCar.Brake();
            CarUtilities.Displaycar(myCar);
        }  
     }
}