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

