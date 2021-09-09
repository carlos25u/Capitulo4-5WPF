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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int b = Convert.ToInt32(baseTextBox.Text);
            int exp = Convert.ToInt32(ExponenteTextBox.Text);
            int calculo = 1;

            for(int i = 1; i <= exp; i++)
            {
                calculo *= b; 
            }

            ResultadoLabel.Content = calculo.ToString();
        }
    }
}
