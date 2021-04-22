using System;

namespace Group_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double UnitConsumed = 0;
            double AmountCharged = 0;
            double SurchargeAmount = 0;
            double NetAmount = 0;

            Console.WriteLine("Welcome to your Water Bill Calculator App");



            Console.WriteLine("Enter your customer ID");
            string CustomerId = Console.ReadLine();

            Console.WriteLine("Enter your Name");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("Enter your Unit consumed");
            UnitConsumed = double.Parse(Console.ReadLine());

            if (UnitConsumed <= 199)
            {
                AmountCharged = UnitConsumed * 1.2;
            }
            else if (UnitConsumed >= 200 && UnitConsumed < 400)
            {
                AmountCharged = UnitConsumed * 1.5;

            }
            else if (UnitConsumed >= 400 && UnitConsumed < 600)
            {
                AmountCharged = UnitConsumed * 1.8;

            }
            else
            {
                AmountCharged = UnitConsumed * 2;
            }


            if (AmountCharged >= 300)
            {
                SurchargeAmount = AmountCharged * 0.15;
                NetAmount = SurchargeAmount + AmountCharged;

            }
            if (AmountCharged <= 100)
            {
                NetAmount = SurchargeAmount + AmountCharged;

            }


            Console.WriteLine($" Customer IDNO: {CustomerId}\n Customer Name: {CustomerName}\n Unit Consumed: {UnitConsumed}\n Amount Charges @ N2.00 per unit: {AmountCharged}\n Surchage Amount: {SurchargeAmount}\n Net Amount paid by the Customer: {NetAmount}");

        }
    }
}
