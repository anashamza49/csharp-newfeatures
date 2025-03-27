using System.ComponentModel.DataAnnotations;
using ImprovedMethods;
using ListPatt;
using Pointers;
using StringInter;

class Program
{
    static void Main(string[] args)
    {
        // Generic attributes
        Eleve eleve = new Eleve("Anas", 10);
        Console.WriteLine(eleve.GetDescription());
        Console.WriteLine();

        // Generic Math Support
        MyNumber num1 = new(10);
        MyNumber num2 = new(20);

        MyNumber result = MyNumber.Add(num1, num2);
        
        Console.WriteLine($"The result gonna be: {result}");
        Console.WriteLine();

        // IntPtr and UIntPtr
        PointerTypes ptr = new PointerTypes();
        ptr.PrintAddresses();
        Console.WriteLine();

        //String Interpolation
        StringInterpolation str = new StringInterpolation();
        str.Example();
        Console.WriteLine();

        // List Patterns
        ListPatterns list = new ListPatterns();
        list.UseCases();
        Console.WriteLine();

        // Improved method group conversion to delegate
        Improve method = new Improve();
        method.Sum();
        method.SumMethodGroup();
         int x = 60;
        Console.WriteLine(Improve.Filter(x));

    }
}

