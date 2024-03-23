using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static Lab02WPF.ListaIngresos;

namespace Lab02WPF
{
    /// <summary>
    /// Lógica de interacción para ListaIngresos.xaml
    /// </summary>
    public partial class ListaIngresos : Window
    {
        public ListaIngresos()
        {
            InitializeComponent();
            CargarDatosPorDefecto();
        }
        public class Ingreso
        {
            public string Fecha { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Producto { get; set; }
            public string Peso { get; set; }
            public string Transporte { get; set; }
        }

        private void IngresosFilter(object sender, FilterEventArgs e)
        {
            Ingreso ingreso = e.Item as Ingreso;
            if (ingreso != null)
            {
                bool nombreConductorOK = string.IsNullOrEmpty(txtNombreConductor.Text) || ingreso.Conductor.ToLower().Contains(txtNombreConductor.Text.ToLower());
                bool placaOK = string.IsNullOrEmpty(txtPlaca.Text) || ingreso.Placa.ToLower().Contains(txtPlaca.Text.ToLower());
                bool productoOK = string.IsNullOrEmpty(txtProducto.Text) || ingreso.Producto.ToLower().Contains(txtProducto.Text.ToLower());

                e.Accepted = nombreConductorOK && placaOK && productoOK;
            }
        }
        private void CargarDatosPorDefecto()
        {
            List<Ingreso> ingresos = new List<Ingreso>
            {
                new Ingreso { Fecha = "2024-03-23", Placa = "ABC123", Turno = "Mañana", Conductor = "Juan", Producto = "Arroz", Peso = "500 kg", Transporte = "Trailer" },
                new Ingreso { Fecha = "2024-03-24", Placa = "DEF456", Turno = "Noche", Conductor = "María", Producto = "Trigo", Peso = "700 kg", Transporte = "Trailer" },
                new Ingreso { Fecha = "2024-03-25", Placa = "GHI789", Turno = "Tarde", Conductor = "Pedro", Producto = "Maíz", Peso = "600 kg", Transporte = "Camión" }
            };


            dataGridIngresos.ItemsSource = ingresos;
        }

        private void dataGridIngresos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}