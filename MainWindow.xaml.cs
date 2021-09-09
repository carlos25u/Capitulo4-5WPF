using Capitulo4_5WPF.Capitulo4;
using Capitulo4_5WPF.Capitulo5;
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

namespace Capitulo4_5WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejer = new Ejercicio1();
            ejer.Show();
        }

        private void Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();
        }

        private void Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 eje4 = new Ejercicio4();
            eje4.Show();
        }

        private void Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejer5 = new Ejercicio5();
            ejer5.Show();
        }

        private void Ejercicio5Cap5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap5 ejercicio5 = new Ejercicio5Cap5();
            ejercicio5.Show();
        }
    }
}
