using System;

namespace Homework_1
{
    /*
    i. Author: Thatcher Wilson
    ii. Class: MIST352-Fall2026
    iii. HW #1
    iv. This program collects information for 4 products and displays a summary table with calculated totals.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //product 1
            Console.WriteLine("Enter information for product #1");

            Console.WriteLine("Product name:");
            string productName1 = Console.ReadLine();

            Console.WriteLine("Product serial number (numbers only):");
            int serialNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product price:");
            double productPrice1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product quantity:");
            int productQuantity1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product category:");
            string productCategory1 = Console.ReadLine();

            Console.WriteLine();

            //product 2
            Console.WriteLine("Enter information for product #2");

            Console.WriteLine("Product name:");
            string productName2 = Console.ReadLine();

            Console.WriteLine("Product serial number (numbers only):");
            int serialNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product price:");
            double productPrice2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product quantity:");
            int productQuantity2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product category:");
            string productCategory2 = Console.ReadLine();

            Console.WriteLine();

            //product 3
            Console.WriteLine("Enter information for product #3");

            Console.WriteLine("Product name:");
            string productName3 = Console.ReadLine();

            Console.WriteLine("Product serial number (numbers only):");
            int serialNumber3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product price:");
            double productPrice3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product quantity:");
            int productQuantity3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product category:");
            string productCategory3 = Console.ReadLine();

            Console.WriteLine();

            //product 4
            Console.WriteLine("Enter information for product #4");

            Console.WriteLine("Product name:");
            string productName4 = Console.ReadLine();

            Console.WriteLine("Product serial number (numbers only):");
            int serialNumber4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product price:");
            double productPrice4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product quantity:");
            int productQuantity4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product category:");
            string productCategory4 = Console.ReadLine();

            Console.WriteLine();

            //calculate total price for each product
            double totalPrice1 = productPrice1 * productQuantity1;
            double totalPrice2 = productPrice2 * productQuantity2;
            double totalPrice3 = productPrice3 * productQuantity3;
            double totalPrice4 = productPrice4 * productQuantity4;

            //print the summary table
            Console.WriteLine("Name       || Serial  || Price    || Quantity || Category   || Total Price");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine($"{Capitalize(productName1),-10} || {serialNumber1,-7} || {productPrice1,-8:C2} || {productQuantity1,-8} || {Capitalize(productCategory1),-10} || {totalPrice1:C2}");
            Console.WriteLine($"{Capitalize(productName2),-10} || {serialNumber2,-7} || {productPrice2,-8:C2} || {productQuantity2,-8} || {Capitalize(productCategory2),-10} || {totalPrice2:C2}");
            Console.WriteLine($"{Capitalize(productName3),-10} || {serialNumber3,-7} || {productPrice3,-8:C2} || {productQuantity3,-8} || {Capitalize(productCategory3),-10} || {totalPrice3:C2}");
            Console.WriteLine($"{Capitalize(productName4),-10} || {serialNumber4,-7} || {productPrice4,-8:C2} || {productQuantity4,-8} || {Capitalize(productCategory4),-10} || {totalPrice4:C2}");
        }

        static string Capitalize(string text)
        {
            string firstLetter = text.Substring(0, 1).ToUpper();
            string restOfWord = text.Substring(1).ToLower();
            return firstLetter + restOfWord;
        }
    }
}