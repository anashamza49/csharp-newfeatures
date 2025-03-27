using System.ComponentModel.DataAnnotations;
using CollectionExpression;
using ImprovedMethods;
using ListPatt;
using PatternMatch;
using Pointers;
using PrimaryConstructors;
using RawStringLaterals;
using StringInter;
using RefReadOnly;
using DefaultLambda;
using AliasAnyType;
using InlineArrays;
using InlineArraysDemo;

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

        // String Interpolation
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
        Console.WriteLine();

        // Raw string literals
        MyRawString.RawString();
        Console.WriteLine();


        // Auto-default struct
        Vector3 vector3 = new Vector3(1, 2);
        Console.WriteLine(vector3);
        Console.WriteLine();

        /* Vector vector = new Vector(3, 4, 5); */

        // Pattern matching on Spans
        PattMatch.MatchSpan();
        Console.WriteLine();


        // Extended nameof scope
        Employee employee = new Employee();
        Console.WriteLine(employee.GetStartTime());
        Console.WriteLine();


        // Collection expressions
        CollExpr.PrintResult();
        Console.WriteLine();

        // Ref readonly structs
        LargeStruct myStruct = new LargeStruct { Value1 = 1, Value2 = 2, Value3 = 3 };
        myStruct.Display(ref myStruct);
        Console.WriteLine();

        // Default lambda parameters
        DefaultLambdaParameters.DefaultLambda();
        Console.WriteLine();

        // Alias Any Type
        AliasExample.ShowExample();
        Console.WriteLine();

        // Inline Array
        ExempleInlineArrays exemple = new ExempleInlineArrays();
        exemple.AfficherTableau();

    }
}

 

