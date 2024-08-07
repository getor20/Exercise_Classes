internal class Child
{
    
    private string name;
    private string surname;
    private int age;

    
    public Child(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Возраст: {age}");
    }
}
