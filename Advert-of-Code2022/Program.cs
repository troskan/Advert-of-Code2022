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
        static string GetShape(char ch)
        {
            return ch switch
            {
                'A' => "Rock",
                'B' => "Paper",
                'C' => "Scissors",
                'X' => "Rock",
                'Y' => "Paper",
                'Z' => "Scissors",
                _=> throw new Exception($"Invalid char {ch}")
            };
        }
        static int ShapeValue(string s)
        {
            return s switch
            {
                "Rock" => 1,
                "Paper" => 2,
                "Scissors" => 3,
                _ => throw new Exception($"Invalid Shape {s}")
            };
        }
        static bool IsWin(string myShape, string opponent)
        {
            return (myShape,opponent) switch
            {
                ("Rock","Scissors") => true,
                ("Scissors","Paper") => true,
                ("Paper","Rock") => true,
                _ => false
            };
        }        
        static bool IsLoss(string myShape, string opponent)
        {
            return (myShape,opponent) switch
            {
                ("Scissors","Rock") => true,
                ("Rock","Paper") => true,
                ("Paper","Scissors") => true,
                _ => false
            };
        }      
        static bool IsDraw(string myShape, string opponent)
        {
            return (myShape,opponent) switch
            {
                ("Scissors","Scissors") => true,
                ("Rock","Rock") => true,
                ("Paper","Paper") => true,
                _ => false
            };
        }
        static void Main(string[] args)
        {
            int totalScore = 0;

            string path = @"C:\Users\Alvin\Desktop\rcp.txt";

            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string opponentShape = GetShape(line[0]);
                string myShape = GetShape(line[2]);

                totalScore += ShapeValue(myShape);

                if (IsDraw(myShape, opponentShape))
                {
                    totalScore += 3;
                }  
                else if (IsWin(myShape, opponentShape))
                {
                    totalScore += 6;
                }
                else if (IsLoss(myShape, opponentShape))
                {

                }
            }
            Console.WriteLine(totalScore);
            //int totalScore = 0;
            //foreach (string line in lines)
            //{
            //    if (line[0] == 'A' && line[2] == 'Y')
            //    {
            //        totalScore += 2 + 6;
            //    }

            //    else if (line[0] == 'B' && line[2] == 'X')
            //    {
            //        totalScore += 1 + 0;

            //    }

            //    else if (line[0] == 'C' && line[2] == 'Z')
            //    {
            //        totalScore += 3 + 3;

            //    }
            //}
            //Console.WriteLine(totalScore);





            //StreamReader sr = new StreamReader(path);
            //int counter = 0;
            //string ln;

            //int totalScore = 0;

            //List<string> rpcList = new List<string>();

            //for (int i = 0; i < 2500; i++)
            //{
            //    string input = sr.ReadLine();
            //    rpcList.Add(input);
            //    if (input[0] == 'A' && input[2] == 'Y')
            //    {
            //        totalScore += 8;
            //    }
            //    else if (input[0] == 'B' && input[2] == 'X')
            //    {
            //        totalScore += 1;
            //    }
            //    else if (input[0] == 'C' && input[2] == 'Z')
            //    {
            //        totalScore += 6;
            //    }
            //}
            //Console.WriteLine($"Totalscore is = {totalScore}");

            ////1 rock, 2 paper, 3 scissor
            //string A = "Rock";
            //string B = "Paper";
            //string C = "Scissor";


            //foreach (var item in rpcList)
            //{
            //    if (true)
            //    {

            //    }
            //}








            //    while ((ln = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(ln);
            //        counter++;
            //    }
            //    sr.Close();
            //    Console.WriteLine($"File has {counter} lines.");

            //    int sum = 2500 / 3;
            //    int result = sum * 15;
            //    Console.WriteLine();
        }
        
        //List<string> elfsCalories = new List<string>();

        //int elfCalorie = 0;

        //for (int i = 0; i < 5000; i++)
        //{
        //    string input = sr.ReadLine();
        //    if (input != "")
        //    {
        //        elfsCalories.Add(input);
        //    }
        //}
        //elfsCalories.
        //sr.Close();
        //    Console.WriteLine(elfsCalories.Max());

        //    int counter = 0;

        //    foreach (var item in elfsCalories)
        //    {
        //        Console.WriteLine(item);
        //        counter++;
            //}

            //Console.WriteLine(counter);






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