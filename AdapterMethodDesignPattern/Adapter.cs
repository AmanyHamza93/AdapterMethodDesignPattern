using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMethodDesignPattern
{
    public class Adapter : IlegacyService
    {
        private readonly NewService _newService;
        public Adapter(NewService newService)
        {
            _newService = newService;  
        }
        public void LegacyRequest()
        {
            _newService.NewRequest();
        }
    }
}
