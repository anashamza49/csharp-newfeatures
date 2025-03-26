// Generic attributes
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
public class InfoTypeAttribute<T> : Attribute {} // defining our attribute

////////////////////////////////////////////////////////////////////////////