﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Dakota", "Kent City", "pho", "System of a Down");
            Student s2 = new Student("Joshua", "Grand Rapids", "cheese tortellini", "The Black Keys");
            Student s3 = new Student("Tommy", "Raleigh", "indian style curried chicken", "Tom Petty");
            Student s4 = new Student("James", "Grand Rapids", "cheeseburgers and fries", "The Arctic Monkeys");
            Student s5 = new Student("Maricela", "Morelia", "tacos", "Pink Floyd");
            Student s6 = new Student("KimVy", "Grand Rapids", "sushi", "A Tribe Called Quest");
            Student s7 = new Student("Sam", "Grand Rapids", "tacos", "I'm Glad It's You");
            Student s8 = new Student("Cody", "Lawton", "potato soup", "The Strokes");
            Student s9 = new Student("Flaka", "Pristina", "thai", "Dua Lipa");
            Student s10 = new Student("Mahruchirhee", "Teaneck", "chicken wings", "Radiohead");
            Student s11 = new Student("Manik", "Cox'sBazar", "spicy beef curry", "Interpol");
            Student s12 = new Student("Moise", "Grand Rapids", "lasagna", "Cage the Elephant");
            Student s13 = new Student("Liz", "Planet Earth", "smoked salmon", "Young the Giant");
            Student s14 = new Student("Jason", "Holland", "burgers", "Kanye West");
            Student s15 = new Student("Robert", "Detroit", "burgers", "Deep Purple");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            students.Add(s11);
            students.Add(s12);
            students.Add(s13);
            students.Add(s14);
            students.Add(s15);

            students = students.OrderBy(x => x.Name).ToList();

            int num = 0;
            string name = "";
            Student s = students[0];
            int studentsCount = students.Count - 1;
            //bool newStudent = true;

            //string action = "";

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to do? ");
                Console.WriteLine("1) Learn about a student");
                Console.WriteLine("2) Add a new student");
                string response = Console.ReadLine().ToLower();

                if (response == "1")
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Which student would you like to learn about? (enter a number 0-{studentsCount}):");
                        Console.WriteLine();
                        for (int i = 0; i < students.Count; i++)
                        {
                            Student stu = students[i];
                            Console.WriteLine(i + " " + stu.GetName());
                        }

                        string input = "";

                        while (true)
                        {
                            try
                            {
                                input = Console.ReadLine();
                                num = int.Parse(input);

                                s = students[num];

                                name = s.GetName();
                                Console.WriteLine(name);

                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("That student does not exist. Please try again.");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine($"What would you like to learn about {name}?");
                        Console.WriteLine("1) Favorite Food ff");
                        Console.WriteLine("2) Home Town ht");
                        Console.WriteLine("3) Favorite Band fb");

                        while (true)
                        {
                            try
                            {
                                string input2 = Console.ReadLine().ToLower().Trim();

                                if (input2 == "1" || input2 == "ff")
                                {
                                    Console.WriteLine($"{name}'s favorite food is {s.FavoriteFood}.");

                                }
                                else if (input2 == "2" || input2 == "ht")
                                {
                                    Console.WriteLine($"{name}'s home town is {s.HomeTown}.");

                                }
                                else if (input2 == "3" || input2 == "fb")
                                {
                                    Console.WriteLine($"{name}'s favorite band is {s.FavoriteBand}.");

                                }
                                else
                                {
                                    Console.WriteLine("That is not a valid option. Please try again.");
                                    continue;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("That is not a valid option. Please try again.");
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Would you like to know more information about {name}? (Y/N)");
                            string moreInfo = Console.ReadLine().ToLower();

                            if (moreInfo == "y")
                            {
                                Console.WriteLine();
                                Console.WriteLine("What else would you like to know?");
                                continue;
                            }
                            else
                            {
                                break;
                            }

                        }
                        break;
                    }
                }
                else if (response == "2")
                {
                    Console.WriteLine("Enter the student's name");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter the student's home town");
                    s.HomeTown = Console.ReadLine();
                    Console.WriteLine("Enter the student's favorite food");
                    s.FavoriteFood = Console.ReadLine();
                    Console.WriteLine("Enter the student's favorite band");
                    s.FavoriteBand = Console.ReadLine();

                    students.Add(new Student(s.Name, s.HomeTown, s.FavoriteFood, s.FavoriteBand));
                }
                else
                {
                    continue;
                }
            }

        }
    }
}