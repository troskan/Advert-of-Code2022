using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AoC_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AoC_01();



        }
      
        
        
        
        
        
        
        
        static void AoC_01()
        {
            //Key variables.
            string path = @"C:\Users\Alvin\Desktop\elfStats.txt";

            StreamReader sr = new StreamReader(path);

            List<int> elfsCalories = new List<int>();

            int elfCalorie = 0;

            for (int i = 0; i < 2500; i++)
            {
                string input = sr.ReadLine();

                if (input != "")
                {
                    elfCalorie += Convert.ToInt32(input);
                }
                if (input == "")
                {
                    elfsCalories.Add(Convert.ToInt32(elfCalorie));
                    elfCalorie = 0;
                }
            }
            sr.Close();
            Console.WriteLine(elfsCalories.Max());

            int topCalories = 0;
            int counter = 0;

            for (int i = 0; i < 3; i++)
            {
                counter++;
                var index = elfsCalories.IndexOf(elfsCalories.Max());

                topCalories += elfsCalories[index];
                elfsCalories.RemoveAt(index);

                Console.WriteLine(topCalories + " - Counter: " + counter);
            }
        }
    }
}