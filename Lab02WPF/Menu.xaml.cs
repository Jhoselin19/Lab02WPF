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

namespace Lab02WPF
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            RegistroIngresos registro = new RegistroIngresos();
            registro.Show();
        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click_ListarConductores(object sender, RoutedEventArgs e)
        {
            ListaConductores conductores = new ListaConductores();
            conductores.Show();
        }
        private void MenuItem_Click_ListarIngresos(object sender, RoutedEventArgs e)
        {
            ListaIngresos ingresos = new ListaIngresos();
            ingresos.Show();
        }
    }
}
