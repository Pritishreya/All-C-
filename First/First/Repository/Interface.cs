using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Repository
{
    interface Interface
    {
        void Add();
        void Update();
        void Delete();
    }
    class Inventory : Interface
    {
        public void Add()
        {
                Console.WriteLine("Added");
            }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    
    }
}
