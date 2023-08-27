using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerV;

class Program
{
    ////1.Creating methods
    //    static void Main(string[] args)
    //    {
    //        DisplayMessage();
    //        addPrint(15, 67);
    //        Add(15, 67);
    //        Console.WriteLine(Add(67, 15));
    //    }
    //    public static void DisplayMessage()
    //    {
    //        Console.WriteLine("Hello, have a nice day");

    //    }

    //    public static void addPrint (int number1, int number2)
    //    {
    //        int answer = number1 + number2;
    //        Console.WriteLine(answer);
    //    }

    //    public static int Add (int number1, int number2)
    //    {
    //        int answer = number1 + number2;
    //        return answer;


    //!Pass by reference vs Pass by Value

    //    static void Main(string[] args)
    //    {
    //        ////Pass by value
    //        int student1Grade = 75;

    //        GiveExtraCredit(student1Grade);
    //        Console.WriteLine("Pass by value to int {0}", student1Grade);
    //        PrintGiveExtraCredit(student1Grade);




    //        //// Pass by reference

    //        int[] grades = new int[2];
    //        grades[0] = 75;
    //        grades[1] = 80;
    //        GiveExtraCreditArray(grades);
    //        Console.WriteLine("Pass by reference to array (Void) {0}", grades[0]);
    //        Console.WriteLine("Pass by reference to array (Void) {0}", grades[1]);


    //    }

    //    public static void GiveExtraCredit(int studentsGrade)
    //    {
    //        studentsGrade += 3;
    //    }

    //    public static void PrintGiveExtraCredit(int studentsGrade)
    //    {
    //        studentsGrade += 3;
    //        Console.WriteLine("Pass by value to int BUT PRINTED (Void) {0}", studentsGrade);
    //    }

    //    public static void GiveExtraCreditArray(int[] grades)
    //    {
    //        grades[0] += 3;
    //    }
    //}


    //!Reference keyword
    //static void Main(string[] args)
    //    {
    //        int yourValue = 0;
    //        Add(ref yourValue);
    //        Console.WriteLine(yourValue);

    //        int add;
    //        int multiply;
    //        AddAndMulti(5, 6, out add, out multiply);
    //        Console.WriteLine(add);
    //        Console.WriteLine(multiply);
    //    }

    //    public static void Add(ref int yourValue)
    //    {
    //        yourValue = +3;

    //    }


    //    public static void AddAndMulti(int a, int b, out int add, out int multiply)
    //    {
    //        add = a + b;
    //        multiply = a * b;

    //    }


    //////!Params Keyword
    //static void Main(string[] args)
    //{
    //    int[] myArray = { 4, 5, 6, 7, 8, 9 };
    //    PrintArray(myArray);
    //    PrintArray(1, 2, 3, 9, 10, 15, 79);


    //}

    //public static void PrintArray(params int[] array)
    //{
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Console.WriteLine(array[i]);
    //    }
    //}


    //    ////!Method Overloading

    //static void Main(string[] args)
    //{
    //    string z = "N";
    //    string m = "F";

    //    Add(5, 7);
    //    Add(z, m);
    //    Add(3.5, 5.4);

    //}
    //public static void Add(int a, int b)
    //{
    //    int answer = a + b;
    //    Console.WriteLine(answer);

    //}

    //public static void Add(string x, string y)
    //{
    //    string answer = x + " + " + y;
    //    Console.WriteLine(answer);
    //}

    //public static void Add(double c, double d)
    //{
    //double answer = c + d;
    //Console.WriteLine(answer);
    //}


    //////!Optional Parameters
    /*
    static void Main(string[] args)
    {
        Add(5, 6, 7);

        Add(5);

        Add(5, 6);

        Add(5, z: 7);

        Add(5, z: 7, y: 6);

    }

    public static void Add(int x, int y = 1, int z = 5)
    {
        int answer = x + y + z;
        Console.WriteLine(answer);

    }
    */

    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        char[] nameArray = name.ToCharArray();


        Console.WriteLine("What is your second name?");
        string sName = Console.ReadLine();
        char[] sNameArray = sName.ToCharArray();

        


        Console.WriteLine("Where do you live?");
        string city = Console.ReadLine();
        char[] cityArray = city.ToCharArray();

        

        ReversePrint(nameArray);
        ReversePrint(sNameArray);
        ReversePrint(cityArray);


        /*  Code without method
        Array.Reverse(sNameArray);
        Array.Reverse(nameArray);
        Array.Reverse(cityArray);

        string result = "";
        foreach (char person in nameArray)
        {
            result += person;
        }
        result += ", ";

        foreach (char person in sNameArray)
        {
            result += person;
        }
        result += ", ";

        foreach (char person in cityArray)
        {
            result += person;
        }
        result += '.';
        Console.WriteLine(result);
        */

    }

    private static void ReversePrint(char[] array)
    {
        Array.Reverse(array);
        foreach (char a in array)
        {
            Console.Write(a);
        }
        Console.Write(" ");
    }
   


}