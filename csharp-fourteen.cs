/******************************************************************************/

/// <summary>
/// The field keyword
/// </summary>
/// <description>
/// The token field enables you to write a property accessor body without declaring an explicit backing field.
/// </descrption>
/// <remarks>
/// The feature 'field keyword' is currently in Preview and *unsupported*.
/// </remarks>
/// 

namespace FieldKeywordExample
{
    public class FieldKeyword
    {
        public string Message
        {
            get;
            set => field = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Number
        {
            get => field;
            set => field = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Number must be positive.");
        }
    }
}

/******************************************************************************/ 

/// <summary> 
/// Implicit Span Conversions 
/// </summary> 
/// <description> 
/// C# 14 introduces first-class support for System.Span<T> and System.ReadOnlySpan<T> in the language.
/// </description> 
/// <remarks> 
/// Spans improve performance while maintaining safety by supporting implicit conversions
/// </remarks> 

namespace ImplicitSpanConversions
{
    using System;

    public static class SpanExamples
    {
        public static void PrintSpan()
        {
            // Implicit conversion from array to Span<int>
            int[] numbers = { 1, 2, 3, 4, 5 };
            Span<int> numberSpan = numbers;

            Console.WriteLine("Span<int> contents:");
            foreach (var num in numberSpan)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Implicit conversion from array to ReadOnlySpan<int>
            ReadOnlySpan<int> readOnlySpan = numbers;

            Console.WriteLine("ReadOnlySpan<int> contents:");
            foreach (var num in readOnlySpan)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

/******************************************************************************/ 

/// <summary> 
/// Unbound Generic Types and nameof 
/// </summary> 
/// <description> 
/// In C# 14, the argument to nameof can be an unbound generic type. 
/// For example, nameof(List<>) evaluates to "List". 
/// </description> 
/// <remarks> 
/// In previous versions, only closed generic types like List<int> were allowed. 
/// </remarks> 

namespace UnboundGenericNameof
{
    using System.Collections.Generic;

    public static class UnboundGenericExample
    {
        public static void PrintUnboundGenericName()
        {
            // Using nameof with an unbound generic type
            string genericTypeName = nameof(List<>);
            Console.WriteLine($"Unbound Generic Type Name: {genericTypeName}");

            // For comparison, using nameof with a closed generic type
            string closedGenericTypeName = nameof(List<int>);
            Console.WriteLine($"Closed Generic Type Name: {closedGenericTypeName}");
        }
    }
}

/******************************************************************************/ 

/// <summary> 
/// Simple Lambda Parameters with Modifiers 
/// </summary> 
/// <description> 
/// C# 14 allows parameter modifiers (such as ref, in, out) in lambda expressions 
/// without specifying parameter types. 
/// </description> 

namespace LambdaParameterModifiers
{

    public static class LambdaModifiersExample
    {
        public static void DemonstrateLambdaModifiers()
        {
            TryParse<int> parse = (text, out result) => int.TryParse(text, out result);

            if (parse("123", out int number))
                Console.WriteLine($"Parsed: {number}");
            else
                Console.WriteLine("Parsing failed.");
        }
    }

    public delegate bool TryParse<T>(string text, out T result);
}


