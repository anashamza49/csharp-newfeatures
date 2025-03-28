using System.Runtime.CompilerServices;  // required for Unsafe methods

/// <summary>
/// params collections
/// </summary>
/// <description>
/// The params modifier isn't limited to array types. We can now use params with any recognized collection type
/// </descrption>
/// 

namespace paramsCollections{

    public static class Params{
        public static void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

/******************************************************************************/

/// <summary>
/// Using the New Lock Object
/// </summary>
/// <description>
/// In .NET 9, the new Lock object provides even more control over locking
/// </descrption>
///


namespace NewLock
{
    public class Account
    {
        private readonly Lock _lockObject = new();
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            // Acquire the lock
            lock (_lockObject)
            {
                _balance += amount;
            }
        }
        public decimal GetBalance()
        {
            lock (_lockObject)
            {
                return _balance;
            }
        }
    }
}

/******************************************************************************/

/// <summary>
/// New escape sequence
/// </summary>
/// <description>
/// we can use \e as a character literal escape sequence for the ESCAPE character, Unicode U+001B
/// </descrption>
/// <remarks>
/// Previously, we used \u001b or \x1b
/// </remarks>
/// 

namespace NewEscapeSequence
{
    public static class NewEscape{
        public static void PrintNewEscape(){
            string text = "\e[31mThis is red text\e[0m";
            Console.WriteLine(text);
        }
    }
}

/******************************************************************************/

/// <summary>
/// Method group natural type
/// </summary>
/// <description>
/// This feature makes small optimizations to overload resolution involving method groups
/// </descrption>
/// <remarks>
/// The previous behavior was for the compiler to construct the full set of candidate methods for a method group
/// </remarks>
/// 


namespace MethodGroup {
    class NaturalGroupMethod
    {
        // Compatible overload
        public static string TransformValue(int x) => $"Int: {x}";

        // Incompatible overloads (pruned early by C# 13)
        public static void TransformValue(string x) { }
        public static int TransformValue(double x) => (int)x;
    }
}

/******************************************************************************/

/// <summary>
/// Implicit index access
/// </summary>
/// <description>
/// The implicit "from the end" index operator, ^, is now allowed in an object initializer expression
/// </descrption>
/// 
namespace ImplicitIndexAccess
{
    public class TimerRemaining
    {
        public int[] buffer { get; set; } = new int[10];
    }
}

/******************************************************************************/

/// <summary>
/// Allowing Ref Structs
/// </summary>
/// <description>
/// developers can now specify that a type argument for a generic type or method can be a ref struct
/// </descrption>
/// 

public struct MyRefStruct
{
    public int Value;

    public MyRefStruct(int value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

public ref struct Container<T> where T : struct
{
    private T _item;

    public void Show()
    {
        Console.WriteLine("Container holds:");
        if (typeof(T) == typeof(MyRefStruct))
        {
            // Unsafe is used to access the ref struct
            ref MyRefStruct myRefStruct = ref Unsafe.As<T, MyRefStruct>(ref _item);
            myRefStruct.Display();
        }
    }
}

/******************************************************************************/

/// <summary>
/// Overload Resolution Priority Attribute
/// </summary>
/// <description>
///  allows library authors to designate one overload as better than others, improving method resolution in complex scenarios
/// </descrption>
/// 

public class MathHelper
{
    [OverloadResolutionPriority(1)]
    public static void Calculate(double number = 20)
    {
        Console.WriteLine("Double overload called with value: " + number);
    }

    [OverloadResolutionPriority(2)]
    public static void Calculate(int number = 10)
    {
        Console.WriteLine("Integer overload called with value: " + number);
    }
}


/******************************************************************************/

/// <summary>
/// More partial members
/// </summary>
/// <description>
///  You can declare partial properties and partial indexers
/// </descrption>
/// <remarks>
///  can't use an auto-property declaration for implementing a partial property
/// </remarks>

public partial class C
{
    // Declaring declaration
    public partial string Name { get; set; }
}

public partial class C
{
    // implementation declaration:
    private string _name;
    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
}

/******************************************************************************/

/// <summary>
/// The field keyword
/// </summary>
/// <description>
/// enables you to write an accessor body without declaring an explicit backing field in your type declaration
/// </descrption>
/// 

public class PersonField
{
    private string _name;

    public string Name
    {
        get => field;
        set => field = value;
    }

    private string @field;
}