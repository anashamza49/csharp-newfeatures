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



