﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Bus:Logik
    {
        protected int cargo;
        protected int maxCargo=50;

        public Bus(string nom, float fuel,int peoples):base(nom,fuel) 
        {
            this.cargo = peoples;
        }


        public void Activ(int cheslo1,int cheslo2)
        {
            if (cheslo1 == 1)
            {
                CargoAdd(cheslo2);

            } else if (cheslo1 == 2) 
            {
                CargoRemove(cheslo2);
            }
        }



        public override void OutInfo()
        {
            Console.WriteLine($"Расход: {(cargo * 0.25F) + (RetSpees() * 0.25F)}");
            Console.WriteLine($"Человек в салоне: {cargo}");
            base.OutInfo();  
        }

        private void CargoAdd(int gruz)
        {

            if ((cargo + gruz) <= maxCargo && gruz > 0)
            {
                cargo += gruz;
                
            }
            else if ((cargo + gruz) > maxCargo)
            {
                Console.WriteLine($"Мы не можем взять больше {maxCargo}. Набрали максимум.\n\n");
                cargo = maxCargo;
                
            }

        }

        private void CargoRemove(int gruz)
        {
            if ((cargo - gruz) >= 0)
            {
                cargo -= gruz;
                
            }
            else { Console.WriteLine("Тогда кол-во груза станет отрицательным. Выгружаю до конца.\n\n"); cargo = 0; }

        }

        public float ReturnCargo()
        {
            return cargo;
        }





    }
}
