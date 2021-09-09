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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            tablaListBox.Items.Clear();
            int x = Convert.ToInt32(NumeroTextBox.Text);
            int tabla;
            for(int i = 1; i <= 10; i++)
            {
                tabla = x * i;
                tablaListBox.Items.Add(x + "x" + i + "=" + tabla);
            }
        }
    }
}
