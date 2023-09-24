class CustomerQueue{
    Queue<Customer> customerQ = new Queue<Customer>();
    public void Push(Customer customer){
        customerQ.Enqueue(customer);
    }

     public Customer Pop(){
        return customerQ.Dequeue();
    }

    public int NumCustomer(){
        return customerQ.Count;
    }
    
    public bool Empty(){
        return customerQ.Count == 0;
    }
    
}