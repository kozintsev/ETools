using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Класс для объявления атрибутов элемента
 * 
 */
namespace ETools
{

    class UGOAttr
    {
        public string Name // Наименование атриубута
        { 
           get; set;
        }
        public string Value // Значение атриубута
        {
            get;
            set;
        }
        public bool Key;
        public int Order;
    }
}
