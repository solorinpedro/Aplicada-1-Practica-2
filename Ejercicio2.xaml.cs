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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Elevar_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Base.Text);

            int y = Convert.ToInt32(Potencia.Text);
            Base.Clear();
            Potencia.Clear();

            double Resultado = 0;

            Resultado = Math.Pow(x, y);

            resultado.Content = Resultado.ToString();
           
        }
    }
}
