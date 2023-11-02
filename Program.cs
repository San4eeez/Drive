using Drive;



//номер топливо расход люди
Bus bus = new Bus("А777АА", 50, 10,6);

while (true)
{
    bus.OutBus();
    Console.WriteLine("\nВведи дальность поездки: ");
    float trip = int.Parse(Console.ReadLine());
    bus.Move(trip);
}

