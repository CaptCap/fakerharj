using Faker;
internal class Program
{
    private static void Main(string[] args)
    
    {
        for (int i =1; i<=3; i++)
    {
        var name = Faker.Name.FullName();
        var city = Faker.Address.City();
        var id = Faker.RandomNumber.Next(100000000);

        Console.WriteLine($"Hello, {name} from {city} id {id}");
        }
    }
}