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

using Navitur.Views.Catalogos;
using Navitur.Views.AdministrarUsuarios;
 

namespace Navitur.Views.Main
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void AdministrarUsuarios_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<AdminUsuarios>().Count() == 0)
            {
                AdminUsuarios mw = new AdminUsuarios();
                mw.Show();
            }
        }
        private void PerfilUsuarios_Click(object sender, RoutedEventArgs e) { }
        private void FechasPagoTotal_Click(object sender, RoutedEventArgs e) { }
        private void Configuracion_Click(object sender, RoutedEventArgs e) { }
        private void Agencias_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<CatAgencias>().Count() == 0)
            {
                CatAgencias mw = new CatAgencias();
                mw.Show();
            }
        }

        private void Proveedores_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<CatProveedores>().Count() == 0)
            {
                CatProveedores mw = new CatProveedores();
                mw.Show();
            }
        }


        private void Hoteles_Click(object sender, RoutedEventArgs e) { }

        private void Agentes_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<CatalogoAgentes>().Count() == 0)
            {
                CatalogoAgentes mw = new CatalogoAgentes();
                mw.Show();
            }
        }

        private void Barcos_Click(object sender, RoutedEventArgs e)
        {

  

        }

        private void Navieras_Click(object sender, RoutedEventArgs e) { }
        private void Aerolineas_Click(object sender, RoutedEventArgs e) { }
        private void Destino_Click(object sender, RoutedEventArgs e) { }
        private void Origen_Click(object sender, RoutedEventArgs e) { }
        private void AgentesAgencias_Click(object sender, RoutedEventArgs e) { }
        private void AgentesProveedores_Click(object sender, RoutedEventArgs e) { }
        private void Salidas_Click(object sender, RoutedEventArgs e) { }
        private void NuevaReservacion_Click(object sender, RoutedEventArgs e) { }
        private void General_Click(object sender, RoutedEventArgs e) { }
        private void OtrosCargos_Click(object sender, RoutedEventArgs e) { }
        private void CobrosyPagos_Click(object sender, RoutedEventArgs e) { }
        private void ConsultaCobrosyPagos_Click(object sender, RoutedEventArgs e) { }
        private void SaldosyCierres_Click(object sender, RoutedEventArgs e) { }
        private void InfoTravelerChecks_Click(object sender, RoutedEventArgs e) { }
        private void FormasdePagos_Click(object sender, RoutedEventArgs e) { }








    }
}
