using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Models
{
    public class Food : Drawer// наследует все функции,методы от класса drawer
    {
        [Serializable]
        public Food()// конструктор
        {
            sign = '$';
        }
    }
}