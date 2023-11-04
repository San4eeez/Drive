using Drive;

//номер топливо расход груз. двигатель всегда потребляет
Bus bus = new Bus("А777АА", 50, 3, 0);
Truck truck = new Truck("П644ОН", 60, 5, 0);
int what;


while (true)
{

   
    
    Console.WriteLine("Меню действий\n1 - Вывести информацию об ТС\n2 - Ехать\n3 - Изменить нагрузку\n4 - Изменить скорость\n5 - Заправка\n6 - Сменить ТС");
    Console.Write("Ввод: ");
    what = int.Parse(Console.ReadLine());
    if (what == 1)
    {
        Console.Clear();
        bus.Out();
    }

    if (what == 2)
    {
        Console.Clear();
        Console.WriteLine("\nВведи дальность поездки: ");
        float trip = int.Parse(Console.ReadLine());
        bus.Move(trip);
    }


    if (what == 3) 
    {
        Console.Clear();
        Console.WriteLine("Изменить колличество полезной нагрузки. ЦЕЛОЕ ЧИСЛО)");
        Console.WriteLine("1 - Добавить нагрузку. 2 - Уменьшить нагрузку");
        Console.Write("Ввод: ");

        int what2 = int.Parse(Console.ReadLine());
        Console.Write("Насколько изменилось кол-во: ");
        int cheslo = int.Parse(Console.ReadLine());

        
        if (what2 == 1)
        {
            bus.CargoAdd(cheslo);
            Console.Clear();
        }

        if (what2 == 2)
        {
            bus.CargoRemove(cheslo);
            Console.Clear();
        }

    }

    if (what == 4)
    {
        Console.Clear();
        Console.WriteLine("Изменить скорость.");
        Console.WriteLine("1 - Ускориться. 2 - Притормозить");
        Console.Write("Ввод: ");

        int what2 = int.Parse(Console.ReadLine());
        Console.Write("Насколько изменить скорость: ");
        int cheslo = int.Parse(Console.ReadLine());


        if (what2 == 1)
        {
            bus.speedAdd(cheslo);
            Console.Clear();
        }

        if (what2 == 2)
        {
            bus.speedRemove(cheslo);
            Console.Clear();
        }
    }

    if (what==5)
    {
        Console.Clear();
        Console.Write("Сколько заливать: ");
        bus.zaprawka(float.Parse(Console.ReadLine()));
    }

}
