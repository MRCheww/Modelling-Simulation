class Cashier{
    double payment = 0;

    public void Pay (int num){
        payment = payment + num * .1;
    }
    
    public double GetProfit(){
        return payment;
    }

}