using Drive;

//номер топливо расход груз. двигатель всегда потребляет
Bus bus = new Bus("А777АА", 50, 3, 0);
Truck truck = new Truck("П644ОН", 60, 5, 0);
int what;
Console.WriteLine("Выбери ТС\n1 - Автобус.\n2 - Картофелевоз");
Console.Write("Ввод: ");
int car = int.Parse(Console.ReadLine())-1;
Console.Clear();
while (true)
{

   
    
    Console.WriteLine("Меню действий\n1 - Вывести информацию об ТС\n2 - Ехать\n3 - Изменить нагрузку\n4 - Изменить скорость\n5 - Заправка\n6 - Сменить ТС");
    Console.Write("Ввод: ");
    what = int.Parse(Console.ReadLine());
    if (what == 1)
    {
        Console.Clear();


        if (car == 0)
        {
            bus.Out();
        } else truck.Out();

    }

    if (what == 2)
    {
        Console.Clear();
        Console.Write("Введи дальность поездки: ");
        float trip = int.Parse(Console.ReadLine());


        if (car == 0)
        {
            float x = bus.ReturnCargo();
            bus.Move(trip, x);
        }
        else
        {
            float x = truck.ReturnCargo();
            truck.Move(trip, x); 
        }

        Console.Clear();
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


            if (car == 0)
            {
                bus.CargoAdd(cheslo);
            }
            else truck.CargoAdd(cheslo);


            Console.Clear();
        }

        if (what2 == 2)
        {
            if (car == 0)
            {
                bus.CargoRemove(cheslo);
            }
            else truck.CargoRemove(cheslo);
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


            if (car == 0)
            {
                bus.speedAdd(cheslo);
            }
            else truck.speedAdd(cheslo);
            Console.Clear();


            Console.Clear();
        }

        if (what2 == 2)
        {

            if (car == 0)
            {
                bus.speedRemove(cheslo);
            }
            else truck.speedRemove(cheslo);
            Console.Clear();
        }
    }

    if (what==5)
    {
        Console.Clear();
        Console.Write("Сколько заливать: ");

        if (car == 0)
        {
            bus.zaprawka(float.Parse(Console.ReadLine()));
        }
        else truck.zaprawka(float.Parse(Console.ReadLine()));


    }

    if(what == 6)
    {
        Console.Clear();
        Console.WriteLine("\"Выбери ТС\\n1 - Автобус.\\n2 - Картофелевоз\"");
        Console.Write("Ввод: ");
        car = int.Parse(Console.ReadLine()) - 1;
    }



}
//Он не умер в конце драйва