using System.Dynamic;

class Customer{
    int totalnumPrint;
    public Customer (int numPrint){
         totalnumPrint = numPrint;
    }
    
    public int GetPrintNum (){
        return  totalnumPrint;
    }
     
}