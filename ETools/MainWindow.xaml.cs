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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ETools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var splash = new SplashScreen("spalsh.png");
            //splash.Show(false);
            //splash.Show(true);
            InitializeComponent();
            splash.Close(TimeSpan.FromMinutes(0.5));
        }

        private void AddClass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyTree_Selected_Item(object sender, RoutedEventArgs e)
        {

        }
    }
}
