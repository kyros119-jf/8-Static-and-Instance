namespace CarNamespace
{
   public class Car
    {
        // Instance fields store information for each Car object

        public string model;
        public int speed;


 // Constructor initializes a new Car with a model and starting speed
    public Car(string model)
        {    
        this.model = model;
        speed = 0;
        }


    public void Accelerate()    
        {
            speed += 10;
        }

    public void Brake()    
        {
            speed -= 10;
        }
    }    

}
