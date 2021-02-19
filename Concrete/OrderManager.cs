using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager
    {
        private ICampainService _campainService;

        public OrderManager(ICampainService campainService)
        {
            _campainService = campainService;
        }
    }
}
