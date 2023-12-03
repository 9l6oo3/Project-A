namespace Day13_P2;
class Program
{
    static void Main(string[] args)
    {
        Cashier ch1 = new Cashier(new Cash());
        Cashier ch2 = new Cashier(new VisaCard());
        Cashier ch3 = new Cashier(new MasterCard());
        Cashier ch4 = new Cashier(new Debit());

        ch1.CheckOut(112.90m);
        ch2.CheckOut(112.90m);
        ch3.CheckOut(112.90m);
        ch4.CheckOut(112.90m);
    }
}

