//3 rooms silver , gold , bronz prices accordingly choice of the room , clac acc to no. of days , name , gov id , phone no. 

using System;

namespace HotelBookingSystem
{
    enum PackageType
    {
        Gold,
        Silver,
        Bronze
    }

    class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string AadharNumber { get; set; }

        public Customer(string name, string ph_no, string adh_no)
        {
            Name = name;
            PhoneNumber = ph_no;
            AadharNumber = adh_no;
        }
    }

    class Program
    {
        static double[] packagePrices = { 5000, 3000, 1500 };
        static double[] servicePrices = { 1000, 500, 300, 800, 600 };

        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string ph_no = Console.ReadLine();

            Console.Write("Enter Aadhar Number: ");
            string adh_no = Console.ReadLine();

            Customer customer = new Customer(name, ph_no, adh_no);

            Console.WriteLine("Select Package: 0 - Gold, 1 - Silver, 2 - Bronze");
            PackageType packageChoice = (PackageType)int.Parse(Console.ReadLine());
            double packageCost = packagePrices[(int)packageChoice];

            Console.Write("Enter number of days: ");
            int numberOfDays = int.Parse(Console.ReadLine());

            double totalServiceCost = 0;
            string[] services = { "Spa", "Laundry", "Gym", "LocalTourism", "TaxiService" };
            for (int i = 0; i < services.Length; i++)
            {
                Console.Write($"Do you want {services[i]} service? (1 for Yes, 0 for No): ");
                if (Console.ReadLine() == "1")
                {
                    totalServiceCost += servicePrices[i];
                }
            }

            double totalCost = (packageCost * numberOfDays) + totalServiceCost;

          
            string formattedCost = totalCost.ToString("0.00");

            Console.WriteLine($"Total Cost: {formattedCost}");
        }
    }
}
