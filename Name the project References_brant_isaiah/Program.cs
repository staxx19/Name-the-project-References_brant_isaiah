﻿namespace Name_the_project_References_brant_isaiah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);


            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));


            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck myTruck = new Truck(50, 500, "My TrUck");

            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();


        }
    }
}