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
using AliasAnyTypeX;
using paramsCollections;
using NewLock;
using NewEscapeSequence;
using MethodGroup;
using ImplicitIndexAccess;
using FieldKeywordExample;
using ImplicitSpanConversions;
using UnboundGenericNameof;
using LambdaParameterModifiers;
using PartialMembersExample;
using DotNet8Examples;

unsafe class Program
{

    //C# 11 features

    // Delegate for Group Method
    delegate string MyDelegate(int value);
    static async void Main(string[] args)
    {
        // Generic attributes
        Console.WriteLine("=== Generic attributes ===");
        Eleve eleve = new Eleve("Anas", 10);
        Console.WriteLine(eleve.GetDescription());
        Console.WriteLine();

        // Generic Math Support
        Console.WriteLine("=== Generic Math Support ===");
        MyNumber num1 = new(10);
        MyNumber num2 = new(20);

        MyNumber result = MyNumber.Add(num1, num2);
        
        Console.WriteLine($"The result gonna be: {result}");
        Console.WriteLine();

        // IntPtr and UIntPtr
        Console.WriteLine("=== IntPtr and UIntPtr ===");
        PointerTypes ptr = new PointerTypes();
        ptr.PrintAddresses();
        Console.WriteLine();

        // String Interpolation
        Console.WriteLine("=== String Interpolation ===");
        StringInterpolation str = new StringInterpolation();
        str.Example();
        Console.WriteLine();

        // List Patterns
        Console.WriteLine("=== List Patterns ===");
        ListPatterns list = new ListPatterns();
        list.UseCases();
        Console.WriteLine();

        // Improved method group conversion to delegate
        Console.WriteLine("=== Improved method group conversion to delegate ===");
        Improve method = new Improve();
        method.Sum();
        method.SumMethodGroup();
        int number = 60;
        Console.WriteLine(Improve.Filter(number));
        Console.WriteLine();

        // Raw string literals
        Console.WriteLine("=== Raw string literals ===");
        MyRawString.RawString();
        Console.WriteLine();


        // Auto-default struct
        Console.WriteLine("=== Auto-default struct ===");
        Vector3 vector3 = new Vector3(1, 2);
        Console.WriteLine(vector3);
        Console.WriteLine();

        /* Vector vector = new Vector(3, 4, 5) */

        // Pattern matching on Spans
        Console.WriteLine("=== Pattern matching on Spans ===");
        PattMatch.MatchSpan();
        Console.WriteLine();


/***********************************************************************************/
        
        // C# 12 features

        // Primary Constructros
        Console.WriteLine("=== Primary Constructros ===");
        Employee employee = new Employee();
        Console.WriteLine(employee.GetStartTime());
        Console.WriteLine();

        // Collection expressions
        Console.WriteLine("=== Collection expressions ===");
        CollExpr.PrintResult();
        Console.WriteLine();

        // Ref readonly structs
        Console.WriteLine("=== Ref readonly structs ===");
        LargeStruct myStruct = new LargeStruct { Value1 = 1, Value2 = 2, Value3 = 3 };
        myStruct.Display(ref myStruct);
        Console.WriteLine();

        // Default lambda parameters
        Console.WriteLine("=== Default lambda parameters ===");
        DefaultLambdaParameters.DefaultLambda();
        Console.WriteLine();

        // Alias Any Type
        Console.WriteLine("=== Alias Any Type ===");
        AliasExample.ShowExample();
        Console.WriteLine();


        // Inline arrays
        Console.WriteLine("=== Inline arrays ===");
        MyStruct myStructX = new MyStruct();
        
        // Assign values
        myStructX.Numbers[0] = 10;
        myStructX.Numbers[1] = 20;
        myStructX.Numbers[2] = 30;
        myStructX.Numbers[3] = 40;
        
        // Print values
        Console.WriteLine($"InlineArray values: {myStructX.Numbers[0]}, {myStructX.Numbers[1]}, {myStructX.Numbers[2]}, {myStructX.Numbers[3]}");

        // Print memory addresses (to show values are inline)
        int* p = &myStructX.Numbers[0];
        {
            Console.WriteLine($"Memory Address of Numbers[0]: {(long)p:X}");
        }
        Console.WriteLine();

        // Experimental Attribute
        #pragma warning disable Test001
        ExperimentalAttributeDemo.Print();
        Console.WriteLine();

        //

        



/***********************************************************************************/
        Console.WriteLine("\n $$$ C# 13 Features $$$ ");
        // C# 13

        // params Collections
        Console.WriteLine("\n=== params Collections ===\n");

        Params.Concat(1, 2, 3, 4, 5); //using integers
        Params.Concat("Bonjour", "le", "monde"); // string
        int[] numbers = [10, 20, 30]; // table
        Params.Concat(numbers);
        Console.WriteLine();
/**/

        // New lock object
        Console.WriteLine("=== New lock object ===");
        Account account = new Account();
        
        account.Deposit(50);
        account.Deposit(150);
        
        Console.WriteLine($"Sold : {account.GetBalance()}");
        Console.WriteLine();


        // New escape sequence
        Console.WriteLine("=== New escape sequence ===");
        NewEscape.PrintNewEscape();
        Console.WriteLine();


        // Method Group Natural Type Improvements
        Console.WriteLine("=== Method Group Natural Type Improvements ===");
        MyDelegate del = NaturalGroupMethod.TransformValue; // Method group conversion
        Console.WriteLine("Method Group Result: " + del(10));
        Console.WriteLine();


        // Implicit index access
        Console.WriteLine("=== Implicit index access ===");
        var countdown = new TimerRemaining();

            countdown.buffer[^1] = 0;
            countdown.buffer[^2] = 1;
            countdown.buffer[^3] = 2;
            countdown.buffer[^4] = 3;
            countdown.buffer[^5] = 4;
            countdown.buffer[^6] = 5;
            countdown.buffer[^7] = 6;
            countdown.buffer[^8] = 7;
            countdown.buffer[^9] = 8;
            countdown.buffer[^10] = 9;
        
        Console.WriteLine("Buffer contents (indexed):");
        for (int i = 0; i < countdown.buffer.Length; i++)
        {
            Console.WriteLine($"buffer[{i}] = {countdown.buffer[i]}");
        }
        Console.WriteLine();

        // Allowing Ref Structs
        Console.WriteLine("=== Allowing Ref Structs ===");
        MyRefStruct myStruct2 = new MyRefStruct(42);
        Container<MyRefStruct> container = new Container<MyRefStruct>();
        container.Show();
        Console.WriteLine();

        // Overload Resolution Priority Attribute
        Console.WriteLine("=== Overload Resolution Priority Attribute ===");
        MathHelper.Calculate(); // Calls the integer overload due to higher priority
        MathHelper.Calculate(5); // Calls the integer overload
        MathHelper.Calculate(5.5); // Calls the double overload due to implicit conversion


        // More partial members
        Console.WriteLine("===  More partial members===");
        C c = new C();

        c.Name = "Anass";
        Console.WriteLine("Name: " + c.Name);

        // The field keyword
        Console.WriteLine("=== The field keyword ===");
        PersonField person1 = new PersonField();
        person1.Name = "Anass";
        Console.WriteLine(person1.Name);

        // ref and unsafe in iterators and async methods
        Console.WriteLine("===  ref and unsafe in iterators and async methods===");

        Programa.ExampleAsync();

        foreach (var item in Programa.ExampleIterator())
        {
            Console.WriteLine($"Iterator yielded: {item}");
        }


/***********************************************************************************/
 
    // C# 14

        /// The field keyword
        Console.WriteLine("=== The field keyword ===");
        FieldKeyword example = new FieldKeyword();
        Console.WriteLine();
        example.Message = "Hello, World!";
        Console.WriteLine($"Message: {example.Message}");
        Console.WriteLine();
        example.Number = 10;
        Console.WriteLine($"Number: {example.Number}");
        // Testing an invalid value for Number (will throw an exception)
        // example.Number = -5;
        Console.WriteLine();

/**/

        // Implicit Span Conversions 
        Console.WriteLine("=== Implicit Span Conversions ===");
        SpanExamples.PrintSpan();
        Console.WriteLine();

/**/

        // Unbound Generic Types and nameof
        Console.WriteLine("=== Unbound Generic Types and nameof ===");
        UnboundGenericExample.PrintUnboundGenericName();
        Console.WriteLine();

/**/

        // Simple Lambda Parameters with Modifiers 
        Console.WriteLine("=== Simple Lambda Parameters with Modifiers  ===");
        LambdaModifiersExample.DemonstrateLambdaModifiers();
        Console.WriteLine();

/**/
        // More partial members
        Console.WriteLine("=== More partial members  ===");
        static void OnEventTriggered(object sender, EventArgs e) => Console.WriteLine("Event triggered!");
        var person = new Person("Anass HAMZAOUI");
        Console.WriteLine(person.Name);

        var eventExample = new EventExample();
        eventExample.AddEventHandler(OnEventTriggered);
        eventExample.Trigger();
        eventExample.RemoveEventHandler(OnEventTriggered);
        eventExample.Trigger();

    }
}




// this one is for Interceptors (not working)
// class ProgramX
// {
//     static void Main()
//     {
//         Console.WriteLine(GetMessage()); 
//     }

//     public static string GetMessage()
//     {
//         return "Original message!!";
//     }
// }
// }


 

