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
using Navitur.ViewModel;


namespace Navitur.Views.Catalogos
{
    /// <summary>
    /// Lógica de interacción para CatAgencias.xaml
    /// </summary>
    public partial class CatAgencias : Window
    {
        public CatAgencias()
        {
            InitializeComponent();

            CatAgenciasViewModel vm = new CatAgenciasViewModel();
            DataContext = vm;
        }


        private void txtClave_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtClave_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtNombre_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNombre_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtNombreAgencia_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNombreAgencia_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtRazonSocial_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtRazonSocial_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtRFC_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtRFC_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtCalle_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtCalle_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtNumInterior_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNumInterior_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtNumExterior_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNumExterior_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtColonia_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtColonia_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtCP_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtCP_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtTelefono_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtTelefono_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtEmail_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtEmail_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtComision_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtComision_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtObservaciones_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtObservaciones_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

       



    }
}
