using System;

namespace rpg_suka
{
    class Program
    {
        public class Person
        {
            public string nick;
            public string type;
            public int health;
            public int damage;
            public Person(string nick)
            {
                this.nick = nick;
            }
            public void fight()
            {
                Console.WriteLine("Нажмите клавишу 'А' для аттаки и клавишу 'О' для отступления");
                char but;
                int enemy;
                but = char.Parse(Console.ReadLine());
                if (but == 'О') { health -= 100; Console.WriteLine("Вы вступили в ряды крыс!"); }
                if (but == 'А')
                {
                    Random random = new Random();
                    enemy = random.Next(40, 60);
                    while ((health > 0) && (enemy > 0))
                    {
                        int next = random.Next(1, 10);
                        if (next % 2 == 0) { health -= 5; Console.WriteLine($"Здоровье:{health}"); }
                        if (next % 2 != 0) { enemy -= 5; Console.WriteLine($"Здоровье врага:{enemy}"); }
                    }
                    if (health <= 0) { Console.WriteLine("Луз"); }
                    else if (enemy <= 0) { Console.WriteLine("Вин"); }
                }
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите никнейм:");
            Person gg = new Person(Console.ReadLine());
            Console.WriteLine("Выбирете класс персонажа:");
            Console.WriteLine("Воин Лучник Маг");
            gg.type = Console.ReadLine();
            if (gg.type == "Воин") { gg.health = 50; gg.damage = 50; }
            else if (gg.type == "Лучник") { gg.health = 30; gg.damage = 60; }
            else if (gg.type == "Маг") { gg.health = 40; gg.damage = 55; }

            Console.WriteLine($"Никнейм: {gg.nick}, Тип персонажа: {gg.type}");
            Console.WriteLine($"Здорорвье: {gg.health}, Дамаг: {gg.damage}");
            gg.fight();
            Console.ReadKey();

        }
    }
}