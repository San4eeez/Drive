using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Bus:Logik
    {
        private int peoples;
        public Bus(string nom, float fuel, float flow,int peoples):base(nom,fuel,flow) 
        {
            this.peoples = peoples;
        }


        public void OutBus()
        {
            
            base.OutInfo();
            
        }

    }
}
