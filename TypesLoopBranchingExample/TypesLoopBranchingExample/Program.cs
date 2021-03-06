﻿namespace TypesLoopBranchingExample
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// COMPANY: Onshore Outsourcing
    /// DESCRIPTION: main class in program
    /// </summary>
    class Program
    {

        /// <summary>
        /// AUTHOR: Giancarlo Rhodes
        /// DESCRIPTION: entry point method
        /// </summary>    
        static void Main(string[] args)
        {

            // some coding logic here

            // create a new Owner
            Owner o = new Owner();
            o.Age = 21;
            o.Gender = "FEMALE";
            o.Name = "Cathy";

            //Console.WriteLine("Age is {0}, Gender is {1}, Name is {2}", o.Age, o.Gender, o.Name);

            // create  a new Car object
            Car _newCar = new Car();
            _newCar.CarOwner = o;
            _newCar.Color = "Red";
            _newCar.Make = "Toyota";
            _newCar.Model = "Camry";
            _newCar.Year = 2018;

            Console.WriteLine("Owner is {0} and they own a {1} {2} {3}", _newCar.CarOwner.Name, _newCar.Year, 
                _newCar.Make, _newCar.Model);

            // ParkingLot _lot = new ParkingLot();
            ParkingLot _lot = new ParkingLot("my lot");

            // calling a method
            _lot.EnteringLot(_newCar);
            _lot.EnteringLot(new Car { Color = "Blue", CarOwner = o });
            _lot.EnteringLot(new Car { Color = "Yellow", CarOwner = new Owner { Age = 33, Gender = "MALE", Name = "Tom" } });

            /*
            int counter = 1;
            foreach (Car item in _lot.ListOfCars)
            {
                Console.WriteLine("Car color is {0} and it is {1} in the list", item.Color, counter);
                // counter = counter + 1;
                counter++;
            }
            */

            _lot.ExitingLot(_newCar);
            Boolean _checklot = _lot.IsLotFull();

            if (_checklot == true)
            {
                Console.WriteLine("It's Full !!!");
            }
            else {

                Console.WriteLine("It's not full !!!");
            }

            Console.ReadLine();
        }


        // GSR 3/5/2019
        //static void Main(string[] args)
        //{

        //    string control = "";

        //    while (control != "exit")
        //    {
        //        // type incoming
        //        Console.WriteLine("Give me a type: int, double, char, boolean");
        //        string typestring = Console.ReadLine();

        //        // value incoming
        //        Console.WriteLine("Give me a value");
        //        string valuestring = Console.ReadLine();
        //        Console.WriteLine("Type is {0} and value is {1}", typestring, valuestring);

        //        // convert to what type??
        //        Console.WriteLine("Convert to what type: int, double, char, boolean?");
        //        string converttype = Console.ReadLine();

        //        // example of branching
        //        if (typestring == "int")
        //        {
        //            // Convert class for convert something to something
        //            int i = Convert.ToInt32(valuestring);
        //            // switch or big if for all conversions
        //            if (converttype == "double")
        //            { 
        //                // convert int to double
        //                double d = (double)i;
        //                Console.WriteLine("Convert int to double: {0}", d.ToString());
        //            }
        //            else if (converttype == "char")
        //            {
        //                // convert int to char
        //                char c;
        //                if ((i >= 0) && (i < 10))
        //                {
        //                    c = 'a';
        //                    Console.WriteLine("Convert int to char: {0}", c.ToString());
        //                }
        //                else {
        //                    c = 'b';
        //                    Console.WriteLine("Convert int to char: {0}", c.ToString());
        //                }

        //            }
        //            else if (converttype == "boolean")
        //            {
        //                // convert int to boolean
        //                Boolean b;
        //                if (i > 0)
        //                {
        //                    b = true;
        //                }
        //                else {
        //                    b = false;
        //                }
        //                Console.WriteLine("Convert int to boolean: {0})", b.ToString());
        //            }


        //        }

        //        if (typestring == "double") {

        //            double d = Convert.ToDouble(valuestring);

        //            switch (converttype)
        //            {
        //                case "int":
        //                    // to convert from a double to an int
        //                    int i = (int)d;
        //                    Console.WriteLine("Converting from a double to an int: {0}", i.ToString());
        //                    break;
        //                case "char":
        //                    // to convert from a double to an char
        //                    char c = 'a';
        //                    Console.WriteLine("Converting from a double to an char: {0}", c.ToString());
        //                    break;
        //                case "boolean":
        //                    // to convert from a double to an boolean
        //                    // convert int to boolean
        //                    Boolean b;
        //                    if (d > 0)
        //                    {
        //                        b = true;
        //                    }
        //                    else
        //                    {
        //                        b = false;
        //                    }
        //                    Console.WriteLine("Convert double to boolean: {0}", b.ToString());
        //                    break;
        //                default:
        //                    break;
        //            }


        //        }




        //        // if "exit", loop will be end
        //        Console.WriteLine("Type 'exit' when done");
        //        control = Console.ReadLine();
        //    }


        //    Console.WriteLine("exited");
        //    Console.ReadLine();
        //}

    }  // class
} // namespace
