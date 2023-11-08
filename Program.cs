using Drive;
//Райан Гослинг...
Console.ForegroundColor = ConsoleColor.Magenta;
string hello = @"
________       _____             
___  __ \_________(_)__   ______ 
__  / / /_  ___/_  /__ | / /  _ \
_  /_/ /_  /   _  / __ |/ //  __/
/_____/ /_/    /_/  _____/ \___/ 
                                 

";
Console.WriteLine(hello);
Console.ResetColor();
//номер топливо груз
Bus bus = new Bus("А777АА", 10, 0);
Truck truck = new Truck("П644ОН", 60, 0);
int what;

Console.WriteLine("Выбери ТС\n1 - Автобус.\n2 - Картофелевоз");
Console.Write("Ввод: ");
int car = int.Parse(Console.ReadLine())-1;
Console.Clear();
while (true)
{


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Меню действий\n1 - Вывести информацию об ТС\n2 - Ехать\n3 - Изменить нагрузку\n4 - Изменить скорость\n5 - Заправка\n6 - Сменить ТС");
    Console.ResetColor();
    Console.Write("Ввод: ");
    what = int.Parse(Console.ReadLine());
    if (what == 1)
    {
        Console.Clear();
        if (car == 0)
        {
            bus.OutInfo();
        } else truck.OutInfo();

    }

    if (what == 2)
    {
        Console.Clear();
        Console.Write("Введи дальность поездки: ");
        
        float trip = int.Parse(Console.ReadLine());
        if (trip < 0)
        {
            Console.WriteLine("Дружок пирожок, ты ввёл неправильное значение. Клуб шутников и кожевенного ремесла двумя этажами ниже.\n\nЕсли усёк, то нажми любую кнопку");
            Console.ReadKey();
        }


        if (car == 0)
        {
            float x = bus.ReturnCargo();
            bus.Action(2,trip, x);
        }
        else
        {
            float x = truck.ReturnCargo();
            truck.Action(2,trip, x); 
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

        
       
            if (car == 0)
            {
                bus.Activ(what2,cheslo);
            }
            else truck.Activ(what2, cheslo);



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
                bus.Action(4,1,cheslo);
            }
            else truck.Action(4, 1, cheslo);
            
        }

        if (what2 == 2)
        {

            if (car == 0)
            {
                bus.Action(4, 2, cheslo);
            }
            else truck.Action(4, 1, cheslo);

        }
    }

    if (what==5)
    {
        Console.Clear();
        Console.Write("Сколько заливать: ");

        if (car == 0)
        {
            bus.Action(5, (float.Parse(Console.ReadLine())),0);
        }
        else truck.Action(5, (float.Parse(Console.ReadLine())), 0);


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