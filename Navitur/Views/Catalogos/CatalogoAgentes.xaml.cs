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
    /// Lógica de interacción para CatalogoAgentes.xaml
    /// </summary>
    public partial class CatalogoAgentes : Window
    {
        public CatalogoAgentes()
        {
            InitializeComponent();

            CatAgentesViewModel vm = new CatAgentesViewModel();
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
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtNombre_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtNombreAgente_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNombreAgente_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtApePat_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtApePat_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtApeMat_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtApeMat_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtCalle_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtCalle_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtNumInterior_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtNumInterior_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtNumExterior_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtNumExterior_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtColonia_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtColonia_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtCP_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtCP_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtMunicipio_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtMunicipio_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtTelefono_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtTelefono_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }



        private void txtCelular_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtCelular_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

















    }
}
