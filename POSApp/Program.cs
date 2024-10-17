using System.Configuration;

namespace POSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorFactory factory1 = TaxCalculatorFactory.Instace;      //new TaxCalculatorFactory();
            Console.WriteLine("factory1" + factory1.GetHashCode());
            TaxCalculatorFactory factory2 = TaxCalculatorFactory.Instace;  //new TaxCalculatorFactory();
            Console.WriteLine("factory2" + factory2.GetHashCode());
            BillingSystem billingSystem = new BillingSystem(factory1.Create());
            billingSystem.GenerateBill();
        }
    }


    class TaxCalculatorFactory
    {

        private TaxCalculatorFactory()
        {

        }

        public static readonly TaxCalculatorFactory Instace = new TaxCalculatorFactory();
        public virtual ITaxCalculatorStrategy Create()
        {
            // do some magic
            // Reflextion

            // read the config 
            string taxClassName = ConfigurationManager.AppSettings["CALC"];
            Type theType = Type.GetType(taxClassName);
            return (ITaxCalculatorStrategy)Activator.CreateInstance(theType);
            //return new KATaxCalculatorStrategy();
        }
    }

    public class BillingSystem
    {

        private ITaxCalculatorStrategy taxCalcStrategy;// = new APTaxCalculatorStrategy();

        public BillingSystem()
        {
            this.taxCalcStrategy = new KATaxCalculatorStrategy();
        }

        public BillingSystem(ITaxCalculatorStrategy strategy)
        {
            this.taxCalcStrategy = strategy;
        }
        public void GenerateBill()
        {
            // scann
            // total
            double totalAmt = 5600.87;
            // total amt
            // discounts
            double discount = 120;
            // tax
            //TaxCalculator taxCalculator = new TaxCalculator();
            double tax = taxCalcStrategy.CalculateTax(totalAmt);
            // offers

            double billAmt = totalAmt + tax - discount;


        }

    }


    public interface ITaxCalculatorStrategy
    {
        double CalculateTax(double amount);
    }

    public class KATaxCalculatorStrategy : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            double cst = 10;
            double kst = 12;
            double cess = 5;
            double sbt = 5;
            double tax = cst + kst + sbt + cess;

            Console.WriteLine("Using KA Tax Calculator");
            return tax;
        }
    }

    public class TNTaxCalculatorStrategy : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            double cst = 10;
            double tst = 12;
            //double cess = 5;
            double abc = 6;
            double sbt = 5;
            double tax = cst + tst + sbt + abc;

            Console.WriteLine("Using TN Tax Calculator");
            return tax;
        }
    }

    public class APTaxCalculatorStrategy : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            double cst = 10;
            double ast = 12;
            //double cess = 5;
            double xyz = 6;
            double sbt = 5;
            double tax = cst + ast + sbt + xyz;

            Console.WriteLine("Using AP Tax Calculator");
            return tax;
        }
    }


    public class USTaxCalc
    {
        public float ComputeTax(float amount)
        {
            //sdfsdfsdfdfasdf
            Console.WriteLine("Using US Tax Calculator");
            return 456.90f;
        }
    }



    public class USTaxCalculatorAdaptor : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            USTaxCalc calc = new USTaxCalc();
            return calc.ComputeTax((float)amount);
        }
    }
}
