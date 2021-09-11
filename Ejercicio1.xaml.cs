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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Multiplicar_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(Numero.Text);
            TablaMultiplicar.Items.Clear();
            for (int x = 1; x <= 10; x++)
            {
                TablaMultiplicar.Items.Add(N + "X" + x + "=" + N * x);
            }
        }
    }
}
