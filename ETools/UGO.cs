using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
/*
 * Класс для определения графического элемента
 * 
 */
namespace ETools
{
    class UGO
    {
        private Guid guid;
        public Guid GUID
        {
            get { return guid; }
            set { guid = value; }
        }
        public ObservableCollection<UGOAttr> ugoAttrs { get; set; }
    }
}
