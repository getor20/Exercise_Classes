class Program
{
    static void Main(string[] args)
    {
       
        Child child1 = new Child("Иван", "Иванов", 10);
        Child child2 = new Child("Мария", "Петрова", 8);

        
        Console.WriteLine("Информация о первом ребенке:");
        child1.ShowInfo();

        Console.WriteLine("\nИнформация о втором ребенке:");
        child2.ShowInfo();
    }
}
