
/// <summary>
/// Generic attributes
/// </summary>
/// <description>
/// now we dont need to use Type and typeof to use our attribute
/// </description>
/// <remarks>
/// Old way: [TypeAttribute(typeof(string))]
/// New way: [GenericAttribute<string>]
/// </remarks>
public class InfoTypeAttribute<T> : Attribute {} // defining our attribute
public class Eleve
{
    [InfoType<string>] // this attribute means that Name gonna be a string
    public string Name { get; set; }

    [InfoType<int>] // the same, this one means that's gonna be an int
    public int Age { get; set; }

    public Eleve(string name, int age)
    {
        Name = name;
        Age = age;
    }

    [InfoType<string>]
    public string GetDescription()
    {
        return $"L'élève s'appelle {Name} et il a {Age} ans.";
    }
}

/******************************************************************************/

/// <summary>
/// Generic math support
/// </summary>
/// <remarks>
/// Static virtual members in interfaces
/// </remarks>
/// <description>
/// with c# 11 we can have static methods in interfaces
/// </description>

public interface ISum<T>{
    static abstract T Add(T a, T b);
}

public class MyNumber : ISum<MyNumber>{
    public int Value {get;}
    public MyNumber (int value) {
        Value = value;
    }

    public static MyNumber Add(MyNumber a, MyNumber b)
    {
        return new(a.Value + b.Value);
    }
}

/******************************************************************************/

/// <summary>
/// Numeric IntPtr (Integer Pointer) and UIntPtr (Unsigned Pointer)
/// </summary>
/// <description>
/// IntPtr and UIntPtr types come into play as essential tools for managing memory addresses and pointer arithmetic
/// </description>
/// <remarks>
/// Useful when working with different memory models and architectures, such as 32-bit and 64-bit systems
/// </remarks>

namespace Pointers {

    public class PointerTypes {

        /// IntPtr
        IntPtr memoryAddress = new IntPtr(0x12345);
        /// UIntPtr
        UIntPtr allocatedMemory = new UIntPtr(0x248595);
        /// Pointer Arithmetic
        public IntPtr nextAddress;
        public PointerTypes()
        {
            nextAddress = memoryAddress + sizeof(int);
        }

        // Use
        public void PrintAddresses()
        {
            Console.WriteLine($"Memory Address: 0x{memoryAddress.ToInt64():X}"); // :X hexadecimal formatting
            Console.WriteLine($"Allocated Memory: 0x{allocatedMemory.ToUInt64():X}");
            Console.WriteLine($"Next Address (After sizeof(int)): 0x{nextAddress.ToInt64():X}");
        }
    }
}

/******************************************************************************/

/// <summary>
/// Newlines in string interpolation expressions
/// </summary>
/// <description>
/// Before C# 11.0, we weren't allowed to split the embedded expressions over multiple lines. Example :
/// </description>
/// <code>
// Console.WriteLine($"The answer is {40
//     +
//     2}");
/// </code>
/// <remarks>
/// Now, we can put newlines inside the braces delimiting an interpolated expression
/// </remarks>

namespace StringInter{
    public class StringInterpolation{
        string individual = "You";
        public void Example ()
        {
            Console.WriteLine($"{individual} {  
                individual switch  
                {  
                    "I" or "You" or "They" => "have",  
                    _ => "has",  
                }} {  
                individual switch  
                {  
                    "I" => "given a confidential security briefing",  
                    "You" => "leaked",  
                    _ => "been charged under section 2a of the Official Secrets Act"  
                }}.");
        }
    }
}

/******************************************************************************/

/// <summary>
/// List Patterns
/// </summary>
/// <description>
/// it allows matchin lists or arrays with simple syntaxe
/// </descrption>

namespace ListPatt {

    public class ListPatterns {

        double[] items1 = { 3.0, 4.0 };

        public void UseCases(){
             
            // Checking an Array with Two Elements
            if (items1 is [double x, double y])
            {
                Console.WriteLine($"Distance from origin: {Math.Sqrt(x * x + y * y)}");
            }

            // Checking if a List is Empty
            if (items1 is [])
            {
                Console.WriteLine("empty list detected!");
            }
            else if (items1 is not [])
            {
                Console.WriteLine("the list isn't empty");
            }
            }
    }
}
/******************************************************************************/

/// <summary>
/// Improved method group conversion to delegate
/// </summary>
/// <description>
/// the code behind method groups was not converted to the same IL code as lambdas or anonymous delegates
/// </descrption>
/// <remarks>
/// The code behind method groups was slower, and not memory efficient.
/// </remarks>

namespace ImprovedMethods{
    public class Improve{
        static readonly List<int> Numbers = Enumerable.Range(0, 100).ToList();

        public int Sum()
        {
            return Numbers.Where(x => Filter(x)).Sum(); // <- faster
        }

        public int SumMethodGroup()
        {
            return Numbers.Where(Filter).Sum(); // <- slower
        }

        public static bool Filter(int number)
        {
            return number > 50;
        }

    }

}









