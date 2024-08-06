




Person person = new Person();
person.SetAge(4); 
Console.WriteLine($"age= {person.GetAge}");


public class Person
{

    public Person() { }
    private int Age = 0;
    public void SetAge(int Age)
    {
        this.Age = Age;
    }
    public int GetAge { get { return this.Age; } }
}


