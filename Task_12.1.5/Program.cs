namespace Task1
{
    class Program
    {
        static void Main()
        {
			var users = new User[]
			{
				new User{ Login = "Qwerty", Name = "Вася", IsPremium = true },
				new User{ Login = "Old1999", Name = "Олег", IsPremium = false },
				new User{ Login = "Diamond", Name = "Сергей", IsPremium = true },
			};

            foreach (var user in users)
				Greetings(user);
        }

		static void Greetings(User user)
        {
            Console.WriteLine("Здравствуйте " + user.Name);
			if (!user.IsPremium)
				ShowAds();
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
}