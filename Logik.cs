using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Logik
    {
        string nom;
        float fuel;
        float flow;
        float currentDistance;

        public Logik(string nom,float fuel,float flow)
        {
            this.nom = nom;
            this.fuel = fuel;
            this.flow = flow;
           

        }

        public void OutInfo()
        {
            Console.WriteLine($"Информация\nНомер: {nom}\nТопливо: {fuel}\nРасход: {flow}");
            Console.WriteLine($"Пройденная дистанция: {currentDistance}\n---------------");

        }

        private void zaprawka(float top)
        {
            
            this.fuel += top;
        }

        public void Move(float km)
        {


            float ostatok = fuel - (km * flow / 100);
            

            if (ostatok >= 0)
            {
                Console.WriteLine("Мы доехали!");
                currentDistance += km;
                fuel = ostatok;
            }
            if (ostatok < 0)
            {
                float tempdist = km - (fuel / (flow / 100));
                Console.WriteLine("Мы не доехали, осталось ещё "+ tempdist);
                ostatok = 0;
                fuel = 0;
                currentDistance += tempdist;
                Console.WriteLine("Чтобы доехать нужно заправиться. Вводи сколько зальём: ");
                zaprawka(float.Parse(Console.ReadLine()));
                Move(tempdist);

            }
            
        }






    }
}
