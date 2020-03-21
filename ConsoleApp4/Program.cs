using System;

namespace rpppppg
{
    class Program
    {
        public class Person
        {
            public string nickname;
            public string type;
            public int health;
            public int damage;
            public Person(string nickname)
            {
                this.nickname = nickname;
            }



            static void Main(string[] args)
            {
                Console.WriteLine("Введите никнейм:");
                Person hero = new Person(Console.ReadLine());
                Console.WriteLine("Выберите класс своего персонажа:");
                Console.WriteLine("Воин 1,Стрелок 2,Волшебник 3,Ассасин 4");
                hero.type = Console.ReadLine();
                if (hero.type == "1") { hero.health = 55; hero.damage = 50; }
                else if (hero.type == "2") { hero.health = 40; hero.damage = 60; }
                else if (hero.type == "3") { hero.health = 45; hero.damage = 55; }
                else if (hero.type == "4") { hero.health = 30; hero.damage = 80; }

                Console.WriteLine($"Никнейм: {hero.nickname}, Тип персонажа: {hero.type}");
                Console.WriteLine($"Здорорвье: {hero.health}, Дамаг: {hero.damage}");
                hero.fight();
               

            }
            public void fight()
            {
                Console.WriteLine("Нажмите клавишу 'F' для аттаки и клавишу 'P' для отступления");
                char but;
                int enemy;
                but = char.Parse(Console.ReadLine());
                if (but == 'P') { health -= 100; Console.WriteLine("Вы нагло струсили......"); }
                if (but == 'F')
                {
                    Random random = new Random();
                    enemy = random.Next(40, 60);
                    while ((health > 0) && (enemy > 0))
                    {
                        int next = random.Next(1, 6);
                        if (next % 2 == 0) { health -= 5; Console.WriteLine($"Здоровье:{health}"); }
                        if (next % 2 != 0) { enemy -= 5; Console.WriteLine($"Здоровье врага:{enemy}"); }
                    }
                    if (health <= 0) { Console.WriteLine("Вы погибли,земля пухом"); }
                    else if (enemy <= 0) { Console.WriteLine("УРААААА!ВЫ ВЫИГРАЛИ"); }
                    Console.ReadKey();
                }
            }

        }
    }
}
