namespace Task;

class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>
        {
            new User { Login = "user1", Name = "Alice", IsPremium = true },
            new User { Login = "user2", Name = "Bob", IsPremium = false },
            new User { Login = "user3", Name = "Charlie", IsPremium = false },
            new User { Login = "user4", Name = "Diana", IsPremium = true }
        };

        GreetUsers(users);
    }

    static void GreetUsers(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"Hello, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}