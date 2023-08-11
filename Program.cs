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
    ////Creating methods
    static void Main(string[] args)
    {
        DisplayMessage();
        addPrint(15, 67);
        Add(15, 67);
        Console.WriteLine(Add(67, 15));
    }
    public static void DisplayMessage()
    {
        Console.WriteLine("Hello, have a nice day");

    }

    public static void addPrint (int number1, int number2)
    {
        int answer = number1 + number2;
        Console.WriteLine(answer);
    }

    public static int Add (int number1, int number2)
    {
        int answer = number1 + number2;
        return answer;
    }
}
