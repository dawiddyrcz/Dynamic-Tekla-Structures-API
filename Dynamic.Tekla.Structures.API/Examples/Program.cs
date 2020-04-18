/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Examples
{
    static class Program
    {
        private static List<ExampleBase> examples = new List<ExampleBase>();

        static void Main(string[] args)
        {
            GetExamples();
            if (examples.Count.Equals(0))
            {
                Console.WriteLine("Sorry there are no examples in this project...");
                Console.ReadKey();
                return;
            }

            PrintExamples();

            var input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                if (value >= 0)
                {
                    try
                    {
                        examples[value].Run();
                    }
                    catch (Dynamic.Tekla.Structures.DynamicAPITeklaNotRunningException ex)
                    {
                        Debug.WriteLine(ex.Message);
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Tekla is not running. Start program and then try again");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                        Console.WriteLine(ex.ToString());
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press eny key to exit...");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Incorrect input. Should be integer grater or equal zero");
            
        }

        private static void PrintExamples()
        {
            Console.WriteLine("Select the number of example to execute. Here is the list: \n");

            for (int i = 0; i < examples.Count; i++)
            {
                Console.WriteLine($"{i} - {examples[i].GetType().Name}");
            }
        }

        private static void GetExamples()
        {
            var exampleTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType.Equals(typeof(ExampleBase))).ToList();

            foreach (var exampleType in exampleTypes)
            {
                examples.Add((ExampleBase)Activator.CreateInstance(exampleType));
            }
        }
    }
}
