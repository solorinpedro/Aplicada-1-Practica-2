using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Asignacion2Aplicada
{
    /// <summary>
    /// Interaction logic for Ejercicicio4Factorial.xaml
    /// </summary>
    public partial class Ejercicicio4Factorial : Window
    {
        public Ejercicicio4Factorial()
        {
            InitializeComponent();
        }

        private void factorial_Click(object sender, RoutedEventArgs e)
        {
            Factorial();
        }
        public void Factorial()
        {
            int Numero = 0;
            Numero = Convert.ToInt32(NumerotextBox.Text);

            int factorial = 1;
            for (int j = 1; j <= Numero; j++)
            {
                factorial = factorial * j;
            }
            resultado.Content = factorial.ToString();
        }
    }
}
