using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesLoopBranchingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string control = "";

            while (control != "exit")
            {
                // type incoming
                Console.WriteLine("Give me a type: int, double, char, boolean");
                string typestring = Console.ReadLine();

                // value incoming
                Console.WriteLine("Give me a value");
                string valuestring = Console.ReadLine();
                Console.WriteLine("Type is {0} and value is {1}", typestring, valuestring);

                // convert to what type??
                Console.WriteLine("Convert to what type: int, double, char, boolean?");
                string converttype = Console.ReadLine();





                // example of branching
                if (typestring == "int")
                {
                    // Convert class for convert something to something
                    int i = Convert.ToInt32(valuestring);
                    // switch or big if for all conversions
                    if (converttype == "double")
                    {
                        // convert int to double
                        double d = (double)i;
                        Console.WriteLine("Convert int to double: {0}", d.ToString());
                    }
                    else if (converttype == "char")
                    {
                        // convert int to char
                        char c;
                        if ((i >= 0) && (i < 10))
                        {
                            c = 'a';
                            Console.WriteLine("Convert int to char: {0}", c.ToString());
                        }
                        else
                        {
                            c = 'b';
                            Console.WriteLine("Convert int to char: {0}", c.ToString());
                        }

                    }
                    else if (converttype == "boolean")
                    {
                        // convert int to boolean
                        Boolean b;
                        if (i > 0)
                        {
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }
                        Console.WriteLine("Convert int to boolean: {0})", b.ToString());
                    }


                }

                if (typestring == "double")
                {

                    double d = Convert.ToDouble(valuestring);

                    switch (converttype)
                    {
                        case "int":
                            // to convert from a double to an int
                            int i = (int)d;
                            Console.WriteLine("Converting from a double to an int: {0}", i.ToString());
                            break;
                        case "char":
                            // to convert from a double to an char
                            char c = 'a';
                            Console.WriteLine("Converting from a double to an char: {0}", c.ToString());
                            break;
                        case "boolean":
                            // to convert from a double to an boolean
                            // convert int to boolean
                            Boolean b;
                            if (d > 0)
                            {
                                b = true;
                            }
                            else
                            {
                                b = false;
                            }
                            Console.WriteLine("Convert double to boolean: {0}", b.ToString());
                            break;
                        default:
                            break;
                    }


                }




                // if "exit", loop will be end
                Console.WriteLine("Type 'exit' when done");
                control = Console.ReadLine();
            }


            Console.WriteLine("exited");
            Console.ReadLine();


        }
    }
}
