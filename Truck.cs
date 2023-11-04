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
            Console.WriteLine($"Мешков картошки: {cargo}");
            base.OutInfo();


        }

        public void CargoAdd(int gruz)
        {

            if ((cargo + gruz) <= maxCargo && gruz > 0)
            {
                cargo += gruz;
                flow += gruz * 0.25F;
                speedRemove(gruz * 0.2F);
            }
            else if ((cargo + gruz) > maxCargo)
            {
                Console.WriteLine($"Мы не можем взять больше {maxCargo}. Набрали максимум.");
                cargo = maxCargo;
                flow += 0.25F + (maxCargo - cargo) * 0.25F;
                speedRemove((maxCargo - cargo) * 0.2F);
            }

        }

        public void CargoRemove(int gruz)
        {
            if ((cargo - gruz) >= 0)
            {
                cargo -= gruz;
                flow -= gruz * 0.25F;
                speedAdd(gruz * 0.2F);
            }
            else { Console.WriteLine("Не может быть меньше 0"); }

        }






    }
}
