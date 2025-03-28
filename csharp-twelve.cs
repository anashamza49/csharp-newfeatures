using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;


/// <summary>
/// Primary Constructros
/// </summary>
/// <description>
/// its a feature that allows u to change the default of initializing a class by addin paramaters to the constructor
/// </descrption>
/// <remarks>
/// Simplifies object initialization with constructor parameters
/// </remarks>
/// 

namespace PrimaryConstructors{

    public class Employee( TimeSpan startTime, TimeSpan finishTime){

        public Employee() : this(new TimeSpan(5,0,0), new TimeSpan(13,0,0)) { }
        public TimeSpan GetStartTime() {

            return startTime;

        }
    }
///<remarks>
/// Concerns exist about using them due to their mutability in a class. (readonly)
///</remarks>
}

/******************************************************************************/

/// <summary>
/// Collection expressions
/// </summary>
/// <description>
/// its a feature that  allows you to initialise a collection of elements such as Arrays, Spans and Lists in an easier way by using a simpler syntax
/// </descrption>
/// 

namespace CollectionExpression{
    
    public static class CollExpr{
        public static void PrintResult(){

            //Before C# 12.0 we used this syntax :
            int[] myArray1 = new int[] { 10, 20, 30, 40, 50 };
            List<string> myList1 = new List<string> { "apple", "banana", "orange" };


            // with C# 12.0 

            // Array
            int[] demoArray = [10, 20, 30, 40, 50];

            // List
            List<string> demoList = ["apple", "banana", "orange"];

            // Span
            Span<char> demoSpan = ['a', 'b', 'c', 'd', 'e'];

            foreach (var item in demoArray)
            {
                Console.WriteLine(item);
            }
            foreach (var item in demoList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in demoSpan)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/******************************************************************************/

/// <summary>
/// ref readonly parameters
/// </summary>
/// <description>
/// The ref readonly modifier allows passing a structure by reference while ensuring it remains read-only.
/// This improves performance by avoiding unnecessary copying of large structures while preventing modifications.
/// </description>
/// 
namespace RefReadOnly{
    
        public struct LargeStruct
        {
            public int Value1;
            public int Value2;
            public int Value3;

            public void Display(ref readonly LargeStruct largeStruct)
            {
                Console.WriteLine($"Values: {largeStruct.Value1}, {largeStruct.Value2}, {largeStruct.Value3}");
            }
        }

}

/******************************************************************************/

/// <summary>
/// Default lambda parameters
/// </summary>
/// <description>
/// 
/// </description>
/// 
namespace DefaultLambda{
    public static class DefaultLambdaParameters
    {
        public static void DefaultLambda(){

            var GetSquare = (int number) => number * number;

            Console.WriteLine(GetSquare(5));

            var GetSquareWithDefaultValue = (int number = 5) => number * number;

            Console.WriteLine(GetSquareWithDefaultValue());

            Console.WriteLine(GetSquareWithDefaultValue(8));

        }

    }
}

/******************************************************************************/  

/// <summary>  
/// Alias Any Type  
/// </summary>  
/// <description>  
/// This feature allows creating aliases for any type (tuples, arrays, pointers)  
/// </description>  

namespace AliasAnyTypeX
{
    using Age = int;
    using NameList = string[];

    public class AliasExample
    {
        public static void ShowExample()
        {
            Age myAge = 25;
            NameList names = { "Anass", "Hamzaoui", "Junior" };

            Console.WriteLine($"Age: {myAge}");
            Console.WriteLine($"First name: {names[0]}");
        }
    }
}

/******************************************************************************/  

/// <summary>  
/// Inline arrays  
/// </summary>  
/// <description>  
/// Inline arrays enable a developer to create an array of fixed size in a struct type
/// </description>  
/// 

[InlineArray(4)]
struct IntInlineArray
{
    private int _value; // Compiler expands this into an [inline array storage] !!!important 
}

struct MyStruct
{
    public IntInlineArray Numbers; // Stores 4 integers directly inside MyStruct !!!important 
}

/******************************************************************************/   

/// <summary>  
/// Experimental attribute 
/// </summary>  
/// <description>  
/// Types, methods, or assemblies can be marked with the System.Diagnostics.CodeAnalysis.ExperimentalAttribute to indicate an experimental feature.
/// </description>  
/// 
namespace DotNet8Examples
{
    [Experimental(diagnosticId: "Test001")]
    public static class ExperimentalAttributeDemo
    {
        public static void Print()
        {
            Console.WriteLine("Hello Experimental Attribute");
        }
    }
}

// interceptors r under preview !! can't work

// public static class MyInterceptor
// {
//     [InterceptsLocation(@"C:\Users\drham\OneDrive\Bureau\csharp-newfeatures\Program.cs", line: 7, character: 27)]
//     public static string InterceptGetMessage()
//     {
//         return "Message intercepté !";
//      }
// }