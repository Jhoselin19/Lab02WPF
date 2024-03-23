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
    /// Lógica de interacción para ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        public ListaConductores()
        {
            InitializeComponent(); 
            CargarDatosPorDefecto();
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public string Licencia { get; set; }
            public string Transporte { get; set; }
        }
        private void CargarDatosPorDefecto()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Licencia = "B1", Transporte = "Trailer" },
                new Persona { Nombre = "María", Licencia = "B1", Transporte = "Trailer" },
                new Persona { Nombre = "Pedro", Licencia = "B1", Transporte = "Trailer" }
            };

            dataGridPersonas.ItemsSource = personas;
        }
    }
}