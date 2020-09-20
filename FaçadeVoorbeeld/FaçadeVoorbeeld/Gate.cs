using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class Gate
    {
        public void OpenTemporary()
        {
            Console.WriteLine("The gate will be temporarily opened");
        }
        public void Open()
        {
            Console.WriteLine("The gate will be opened");
        }
        public void Close()
        {
            Console.WriteLine("The gate will be closed");
        }
    }
}
