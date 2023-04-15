// See https://aka.ms/new-console-template for more information

using TheSunSystem;

List<Star> stars = new List<Star>();
stars.Add(new Star("Солнце",4500000000,20000));

List<Planet> planets = new List<Planet>();
planets.Add(new Planet("Меркурий",3900000000,0.055,stars));
planets.Add(new Planet("Венера",3900000000,0.815,stars));
planets.Add(new Planet("Земля",3900000000,1,stars));
planets.Add(new Planet("Марс",3900000000,0.107,stars));

List<Moon> moons = new List<Moon>();
moons.Add(new Moon("Луна",4425000000,0.0123,planets[2]));
moons.Add(new Moon("Фобос",4425000000,166*10^-11,planets[3]));
moons.Add(new Moon("Деймос",4425000000,148*10^-12,planets[3]));

StarSystem sunSystem = new StarSystem(stars,planets,moons);

int change = 0;
while (change != 10)
{
    Console.WriteLine("1 - показать все звёзды, 2 - показать определённую звезду, 3 - добавить звезду, 4 - показать все планеты, 5 - показать определённую планету," +
                      "6 -  добавить планету, 7 - показать все луны, 8 - показать определённую луну, 9 - добавить луну, 10 - выход.");
   change = Convert.ToInt32(Console.ReadLine());
   int index;
   string? name;
   long age;
   double weight;
   switch (change)
   {
       case 1: sunSystem.StarsShow();
           break;
       case 2: Console.WriteLine("Введите номер звезды:");
           index = Convert.ToInt32(Console.ReadLine());
           sunSystem.StarShow(index);
           break;
        case 3: Console.WriteLine("Добавление звезды: ");
            Console.WriteLine("Название звезды:");
            do
            {
                name = Console.ReadLine();
            } while (String.IsNullOrEmpty(name));
            Console.WriteLine("Возраст звезды:");
            age = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Масса звезды:");
            weight  = Convert.ToDouble(Console.ReadLine());
            sunSystem.Stars.Add(new Star(name,age,weight));
            break;
       case 4: sunSystem.PlanetsShow();
           break;
       case 5: Console.WriteLine("Введите номер планеты:");
           index =Convert.ToInt32(Console.ReadLine());
           sunSystem.PlanetShow(index);
           break;
       case 6: Console.WriteLine("Добавление планеты: ");
           Console.WriteLine("Название планеты:");
           do
           {
               name = Console.ReadLine();
           } while (String.IsNullOrEmpty(name));
           Console.WriteLine("Возраст планеты:");
           age =Convert.ToInt64(Console.ReadLine());
           Console.WriteLine("Масса планеты:");
           weight  = Convert.ToDouble(Console.ReadLine());
           sunSystem.PlanetAdd(new Planet(name,age,weight,sunSystem.Stars));
           break;
       case 7: sunSystem.MoonsShow();
           break;
       case 8: Console.WriteLine("Введите номер луны:");
           index = Convert.ToInt32(Console.ReadLine());
           sunSystem.MoonShow(index);
           break;
       case 9: Console.WriteLine("Добавление луны: ");
           Console.WriteLine("Название луны:");
           do
           {
               name = Console.ReadLine();
           } while (String.IsNullOrEmpty(name));
           Console.WriteLine("Возраст луны:");
           age = Convert.ToInt64(Console.ReadLine());
           Console.WriteLine("Масса луны:");
           weight  =Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Название планеты:");
           string? namePlanet;
           do
           {
               namePlanet = Console.ReadLine();
           } while (String.IsNullOrEmpty(namePlanet));
           if (sunSystem.Planets.Any(x => x.Name.Equals(namePlanet)))
           {
               int number = sunSystem.Planets.FindIndex(x => x.Name.Equals(namePlanet));
               sunSystem.Moons.Add(new Moon(name, age, weight, sunSystem.Planets[number]));
           }
           else
           {
               Console.WriteLine("Ошибка! Такой планеты не существует...");
           }
           break;
       case 10: Console.WriteLine("Выход из системы.");
           break;
   }
}