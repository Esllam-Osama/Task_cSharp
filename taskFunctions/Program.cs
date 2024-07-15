namespace taskFunctions;
using System.Collections.Generic;

internal class Program
{
    static void showMsg()
    {
        Console.WriteLine("================================== ");
        Console.WriteLine("P - Print numbers");
        Console.WriteLine("A - Add a number");
        Console.WriteLine("M - Display mean of the numbers");
        Console.WriteLine("S - Display the smallest number");
        Console.WriteLine("L - Display the largest number");
        Console.WriteLine("Q - Quit");
        Console.WriteLine("================================== \n");
        Console.Write("Enter your choice:");
    }
    static void addNumberInLinst(List<int> list)
    {
        
        Console.Write("\nEnter new number:");
        int Number = Convert.ToInt32(Console.ReadLine());
        bool cheakAdd = true;
        if (list.Count > 0) {
            foreach (int i in list) {
                if (Number==i)
                {
                    Console.WriteLine("the number has been aded..!");
                    cheakAdd=false;
                }
            }
        }
        //no repeat in the list
        if (cheakAdd) {
            list.Add(Number);
        }
    }
    static float gitAvrege(List<int> list)
    {
        int count = 0;
        foreach (int item in list)
        {
            count += item;
        }
        return count / list.Count;
    }
    static int gitSmallestNum(List<int> list)
    {
        int smallest = list[0];
        foreach (int item in list)
        {


            if (item < smallest)
            {
                smallest = item;

            }

        }

        return smallest;
    }
    static int gitLargestNum(List<int> list)
    {
        int largest = list[0];
        foreach (int item in list)
        {


            if (largest < item)
            {
                largest = item;

            }

        }

        return largest;
    }
    static void checkOfChoice()
    {
        List<int> userNumbers = new List<int>() { };
        bool check = true;

        do
        {
            showMsg();
            char userChoice = Convert.ToChar(Console.ReadLine());

            if (userChoice == 'p' || userChoice == 'P')
            {
                if (userNumbers.Count() > 0)
                {
                    Console.WriteLine($"\n[{String.Join(" ", userNumbers)}]");
                }
                else
                {
                    Console.WriteLine("[]=>the list is empty");
                }
            }
            else if (userChoice == 'a' || userChoice == 'A')
            {
                addNumberInLinst(userNumbers);
            }
            else if (userChoice == 'm' || userChoice == 'M')
            {
                Console.WriteLine($"avrege is: {gitAvrege(userNumbers)}");
            }
            else if (userChoice == 's' || userChoice == 'S')
            {

                if (userNumbers.Count() > 0)
                {
                    Console.WriteLine("\nthe smallest number is: " + gitSmallestNum(userNumbers));
                }
                else
                {
                    Console.WriteLine("[]=>the list is empty");
                }
            }
            else if (userChoice == 'l' || userChoice == 'L')
            {
                if (userNumbers.Count() > 0)
                {
                    Console.WriteLine("\nthe larest number is: " + gitLargestNum(userNumbers));
                }
                else
                {
                    Console.WriteLine("[]=>the list is empty");
                }
            }
            else if (userChoice == 'q' || userChoice == 'Q')
            {
                Console.WriteLine("\nGood bye");
                check = false;
            }
            else
            {
                Console.WriteLine("================================== ");

                Console.WriteLine("\nsorry the wrong choice \nplease try again \n");
                Console.WriteLine("================================== ");

            }


        } while (check);

    }
    static void Main(string[] args)
    {
        checkOfChoice();
    }
}
