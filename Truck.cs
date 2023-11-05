using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Truck : Logik
    {
        protected int cargo;
        protected int maxCargo = 50;

        public Truck(string nom, float fuel, float flow, int peoples) : base(nom, fuel, flow)
        {
            this.cargo = peoples;
        }





        public void Out()
        {

            Console.WriteLine($"Расход: {(cargo * 0.25F) + (RetSpees() * 0.25F)}");
            Console.WriteLine($"Мешков картошки: {cargo}");
            base.OutInfo();


        }

        public void CargoAdd(int gruz)
        {

            if ((cargo + gruz) <= maxCargo && gruz > 0)
            {
                cargo += gruz;

            }
            else if ((cargo + gruz) > maxCargo)
            {
                Console.WriteLine($"Мы не можем взять больше {maxCargo}. Набрали максимум.");
                cargo = maxCargo;

            }

        }

        public void CargoRemove(int gruz)
        {
            if ((cargo - gruz) >= 0)
            {
                cargo -= gruz;

            }
            else { Console.WriteLine("Не может быть меньше 0"); }

        }

        public float ReturnCargo()
        {
            return cargo;
        }





    }
}
