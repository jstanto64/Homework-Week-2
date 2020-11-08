using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week2Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is prompting the user for degrees in fahrenheit
            Console.WriteLine("Please enter degrees in fahrenheit.");

            //Taking user data and storing it
            int degrees = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Fahrenheit = {0}", degrees);
            Console.WriteLine("Celsius = {0}", (degrees - 32) * 5 / 9);


            //This is prompting the user for price before sales tax
            Console.WriteLine("Please enter the price of your product before sales tax.");

            double price = Convert.ToDouble(Console.ReadLine());


            //This is prompting the user for their sales tax
            Console.WriteLine("Please enter the sales tax for your product.");

            double tax = Convert.ToDouble(Console.ReadLine());

            double taxrate = Convert.ToDouble(tax) / 100;

            double totalprice = price + ( price * taxrate);

            string tp = totalprice.ToString("C");

            //This is telling user their total price
            Console.WriteLine("Your total price is.");

            Console.WriteLine(tp);


            //This is prompting the user for their total bill
            Console.WriteLine("Please enter your total bill amount?");

            double totalbill = Convert.ToDouble(Console.ReadLine());


            //This is prompting user for the amount they would like to tip
            Console.WriteLine("Please enter what percent you would like to tip?");

            double tippercent = Convert.ToDouble(Console.ReadLine());


            //This is prompting user for how much tip they will owe
            Console.WriteLine("This is how much tip you will owe.");

            double totaltip = (double)(totalbill * tippercent) /100;

            string tt = totaltip.ToString("C");

            Console.WriteLine(tt);


            //This is prompting the user for their total bill
            Console.WriteLine("Please enter you total bill amount?");

            double totalbill2 = Convert.ToDouble(Console.ReadLine());

            //This is prompting user for how many people contributing
            Console.WriteLine("Please enter how many people are contributing?");

            double people = Convert.ToDouble(Console.ReadLine());

            //This is telling user how much each person would need to pay
            Console.WriteLine("This is how much each person would need to contribute");

            double eachperson = (double)(totalbill2 / people);

            string ep = eachperson.ToString("C");

            Console.WriteLine(ep);


            Console.ReadLine();


        }
    }
}
