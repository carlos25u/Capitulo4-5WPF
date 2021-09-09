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

namespace Capitulo4_5WPF.Capitulo5
{
    /// <summary>
    /// Interaction logic for Ejercicio5Cap5.xaml
    /// </summary>
    public partial class Ejercicio5Cap5 : Window
    {
        public Ejercicio5Cap5()
        {
            InitializeComponent();
        }

        private void ConversionButton_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(NumeroTextBox.Text);

            if(num == 1)
            {
                resultadoLabel.Content = "Uno";
            }
            if (num == 2)
            {
                resultadoLabel.Content = "Dos";
            }

            if (num == 3)
            {
                resultadoLabel.Content = "Tres";
            }

            if (num == 4)
            {
                resultadoLabel.Content = "Uno";
            }

            if (num == 5)
            {
                resultadoLabel.Content = "Cinco";
            }

            if (num == 6)
            {
                resultadoLabel.Content = "Seis";
            }

            if (num == 7)
            {
                resultadoLabel.Content = "Siete";
            }

            if (num == 8)
            {
                resultadoLabel.Content = "Ocho";
            }

            if (num == 9)
            {
                resultadoLabel.Content = "Nueve";
            }

            if (num == 10)
            {
                resultadoLabel.Content = "Diez";
            }

            if (num == 11)
            {
                resultadoLabel.Content = "Once";
            }

            if (num == 12)
            {
                resultadoLabel.Content = "Doces";
            }

            if (num == 13)
            {
                resultadoLabel.Content = "Trece";
            }

            if (num == 14)
            {
                resultadoLabel.Content = "Catorce";
            }

            if (num == 15)
            {
                resultadoLabel.Content = "Quince";
            }

        }
    }
}
