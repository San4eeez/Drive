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
        protected float flow;
        float currentDistance;
        float speed = 40;
        float maxSpeed = 120;
        float maxFuel = 100;


        public float RetSpees()
        {
            return speed;
        }

        
        public Logik(string nom,float fuel,float flow)
        {
            this.nom = nom;
            this.fuel = fuel;
            this.flow = flow;
        }

       

        public void OutInfo()
        {
            Console.WriteLine($"Информация\nНомер: {nom}\nТопливо: {fuel}\nСкорость: {speed}");
            Console.WriteLine($"Пройденная дистанция: {currentDistance}\n---------------");
        }

        public void speedAdd(float addspeed)
        {
            if ((speed + addspeed) <= maxSpeed && addspeed > 0)
            {
                speed += addspeed;
                
            }
            else if ((speed + addspeed) > maxSpeed)
            {
                Console.WriteLine($"Мы не можем гнать больше {maxSpeed}. Набрали максимум.");
                speed = maxSpeed;
                
            }

        }

        public void speedRemove(float addspeed)
        {
            if ((speed - addspeed) >= 0)
            {
                speed -= addspeed;
               
            }
            else { speed=0; }

        }


        public void zaprawka(float top)
        {
            if (top + fuel < maxFuel)
            {
                this.fuel += top;
            } else
            {
                Console.WriteLine($"Бак ёмкостью {maxFuel}, больше не взять. Залил максимум.");
                this.fuel = maxFuel;
            }
        }

        public void Move(float km,float cargo)
        {
            float time;
            float realFlow = (cargo * 0.25F)+(speed*0.25F);

            if (speed > 0)
            {



                float ostatok = fuel - (km * realFlow / 100);


                if (ostatok >= 0)
                {
                    time = km / speed;
                    Console.WriteLine($"Мы доехали за {time:F2} час(а/ов)");
                    currentDistance += km;
                    fuel = ostatok;

                }
                if (ostatok < 0)
                {
                    float tempdist = km - (fuel / (realFlow / 100));
                    Console.WriteLine("Мы не доехали, осталось ещё " + tempdist);
                    ostatok = 0;
                    fuel = 0;
                    currentDistance += tempdist;
                    Console.WriteLine("Чтобы доехать нужно заправиться. Вводи сколько зальём: ");
                    zaprawka(float.Parse(Console.ReadLine()));
                    Move(tempdist,cargo);

                }

            }
            else
            {
                Console.WriteLine("Скорость должна быть положительной, а так мы не поедем.");
            }
        }









    }
}
