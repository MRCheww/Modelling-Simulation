using MathNet.Numerics.Distributions;

class Simulation{
    static void Main(string[] args)
    {
        int MaxSimTime = 8 * 60; // Minutes
        int Time = 0;
        
        // Queue start from 0
        Random rand = new Random();
        CustomerQueue customerQueue = new CustomerQueue();
        Cashier cashier = new Cashier ();
        
        bool serverFree = true;
        int serviceTime = 0;
        int timeCustomerArrival = rand.Next() % 10;
        int queueSize = 0;
        
        
        // Shop open
        // Simulation Loop
        while (Time<MaxSimTime){
            
            if (timeCustomerArrival == 0){
                Customer customer = new Customer(rand.Next());
                customerQueue.Push(customer);
                timeCustomerArrival = (int) Exponential.Sample(0.1); // rand.Next() % 10; // Exponential
            }
            
            if (serverFree == true && customerQueue.NumCustomer() > 0){
                Customer customer = customerQueue.Pop();
                cashier .Pay (customer .GetPrintNum());
                serviceTime = (int) Normal.Sample(10,5); // rand.Next() % 10; // Gaussian
                serverFree = false;
            }
            else if (serverFree == false){
                serviceTime --;
                
                if (serviceTime == 0){
                    serverFree = true;
                }
            }
            
            queueSize += customerQueue.NumCustomer();
            Console.WriteLine("Queue size = " + customerQueue.NumCustomer());
            timeCustomerArrival --;
            Time ++;
        }
        
        Console.WriteLine("Avg queue lgth = "+ (queueSize/MaxSimTime));
        Console.WriteLine("Total Profit : " + cashier.GetProfit());
    }
}