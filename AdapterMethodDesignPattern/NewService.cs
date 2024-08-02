using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMethodDesignPattern
{
    public class NewService
    {
        public void NewRequest()
        {
            Console.WriteLine("EXEC NewService.NewRequest");
        }
    }
}
