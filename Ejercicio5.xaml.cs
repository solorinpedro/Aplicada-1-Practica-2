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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void MostrarDatos_Click(object sender, RoutedEventArgs e)
        {
            int edad1 = Convert.ToInt32(textboxEdad1.Text);

            int edad2 = Convert.ToInt32(textboxEdad2.Text);

            int edad3 = Convert.ToInt32(textboxEdad3.Text);

            int promedioEdad = edad1 + edad2 + edad3;

            textboxEdad1.Clear();
            textboxEdad2.Clear();
            textboxEdad3.Clear();
            PromedioTextbox.Clear();
            MasgrandeTextbox.Clear();
            jovenTextbox.Clear();
            PromedioTextbox.Text = promedioEdad.ToString();

            if (edad1 > edad2 && edad1 > 3)
            {
                MasgrandeTextbox.Text = edad1.ToString();
            }
            if (edad1 < edad2 && edad1 < edad3)
            {
                jovenTextbox.Text = edad1.ToString();
            }

            if(edad2 > edad1 && edad2 > edad3)
            {
                MasgrandeTextbox.Text = edad2.ToString();
            }
            if (edad2 < edad1 && edad2 < edad3)
            {
                jovenTextbox.Text = edad2.ToString();
            }

            if (edad3 > edad1 && edad3 > edad2)
            {
                MasgrandeTextbox.Text = edad3.ToString();
            }
            if (edad3 < edad1 && edad3 < edad2)
            {
                jovenTextbox.Text = edad3.ToString();
            }
        }
    }
}
