using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> name = new List<string>(new string[] { $"Jacob", "Drew", "Peter" });
            List<string> food = new List<string>(new string[] { "Cookies", "Ices Cream", "Thai" });
            List<string> hometown = new List<string>(new string[] { "Detroit", "Roseville", "Warren" });
            List<string> color = new List<string>(new string[] { });


            try
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Add a new value of color for Jacob, Drew and Peter");
                    string colors = Console.ReadLine();
                    color.Add(colors);
                }



                bool repeat = true;
                while (repeat)
                {




                    Console.WriteLine("Give me a new student name");
                    string names = Console.ReadLine();
                    name.Add(names);

                    Console.WriteLine("Give me a new student hometown");
                    string homeTown = Console.ReadLine();
                    hometown.Add(homeTown);

                    Console.WriteLine("Give me a new student Food");
                    string foods = Console.ReadLine();
                    food.Add(foods);

                    Console.WriteLine("Give me a new student color");
                    string Colors = Console.ReadLine();
                    color.Add(Colors);

                    Console.WriteLine("Would you like to add another student y/n");
                    string input = Console.ReadLine().ToLower();
                    if (input.ToLower() != "y")
                    {
                        repeat = false;
                    }

                }

            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            bool answ = true;
            while (answ)
            {



                Console.WriteLine("Enter a student number" + "\n" + "0 = Jacob, 1 = Drew, 2 = Peter ");


                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("What would you like to learn, Favorite food or Hometown?  (Enter; food/hometown)");
                string answer = Console.ReadLine().ToLower();
                try
                {
                    if (answer == "food")
                    {

                        Console.WriteLine($"You chose {name[input]} they like to eat {food[input]}");


                    }
                    else if (answer == "hometown")
                    {
                        Console.WriteLine($" You chose {name[input]} they  are from {hometown[input]}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");

                    }

                    Console.WriteLine("Would you like to learn more? y/n");
                    string newinput = Console.ReadLine().ToLower();

                    if (newinput == "y" && answer == "food")
                    {

                        Console.WriteLine($"{name[input]} is from {hometown[input]} and there favorite color is {color[input]}");
                        Console.WriteLine("Run Again? y/n");
                        string dataValue = Console.ReadLine();
                        if (dataValue == "y" || dataValue == "Y")
                        {

                        }
                        else if (dataValue == "n")
                        {
                            Console.WriteLine("Goodbye");
                            answ = false;
                        }

                    }
                    else if (newinput == "y" && answer == "hometown")
                    {
                        Console.WriteLine($"{name[input]} likes to eat {food[input]} ");
                        Console.WriteLine("Run Again? y/n");
                        string dataValue = Console.ReadLine().ToLower();
                        if (dataValue == "y")
                        {

                        }
                        else if (dataValue == "n")
                        {
                            Console.WriteLine("Goodbye");
                            answ = false;
                        }

                    }
                    else if (newinput == "n")
                    {
                        Console.WriteLine("Goodbye");
                        answ = false;

                    }

                }
                catch (IndexOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }

    }
}
