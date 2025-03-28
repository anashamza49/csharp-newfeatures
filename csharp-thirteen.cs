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
