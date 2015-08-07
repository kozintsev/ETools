using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/*
 Окно для ввода нового графического элемента
 должно отображать список атрибутов которые должны заполняться
 
 */

namespace ETools
{
    /// <summary>
    /// Interaction logic for WinAddEComponent.xaml
    /// </summary>
    public partial class WinAddEComponent : Window
    {
        public WinAddEComponent()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
