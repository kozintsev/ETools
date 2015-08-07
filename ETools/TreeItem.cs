using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

/*
 * Класс для создания объекта элемент дерева
 * 
 */
namespace ETools
{
    [Serializable]
    class EToolsTreeItem
    {
        public EToolsTreeItem()
        {
            this.eToolsItems = new ObservableCollection<EToolsTreeItem>();
        }
        // Коллекция дочерних объектов
        public ObservableCollection<EToolsTreeItem> eToolsItems { get; set; }

       
        // описание (возможно стоит придумать другое название)
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        // признак является ли Папкой
        public bool IsFolder
        {
            get; set;
        }
        

    }
}
