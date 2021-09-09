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

namespace Capitulo4_5WPF.Capitulo4
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int edad1 = Convert.ToInt32(edad1TextBox.Text);
            int edad2 = Convert.ToInt32(edad2TextBox.Text);
            int edad3 = Convert.ToInt32(edad3TextBox.Text);

            if(edad1 > edad2 && edad1 > edad3)
            {
                mayorLabel.Content = edad1.ToString();
            }

            if (edad1 < edad2 && edad1 < edad3)
            {
                menorLabel.Content = edad1.ToString();
            }

            if (edad2 > edad1 && edad2 > edad3)
            {
                mayorLabel.Content = edad2.ToString();
            }

            if (edad2 < edad1 && edad2 < edad3)
            {
                menorLabel.Content = edad2.ToString();
            }

            if (edad3 > edad1 && edad3 > edad2)
            {
                mayorLabel.Content = edad3.ToString();
            }

            if (edad3 < edad1 && edad3 < edad2)
            {
                menorLabel.Content = edad3.ToString();
            }

        }
    }
}
