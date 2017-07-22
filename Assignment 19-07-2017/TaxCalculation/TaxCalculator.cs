namespace TaxCalculation
{
    public class TaxCalculator
    {
        double tax;
        public double Caculator(double money)
        {
           
            if (money < 1000)
            {
                 tax = (money * 5) / 100;
            }
            else if (100000 >= money && money >= 10000)
            {
                tax = ((9999 * 5) / 100); 
                tax+= (((money - 9999) * 8) / 100);
            }
            else if (money > 100000)
            {
                tax = ((9999 * 5) / 100);
                tax += ((90001 * 8) / 100);
                tax += ((money - 100000) * 8.5) / 100;
            }
            return tax;
        }
    }
}
