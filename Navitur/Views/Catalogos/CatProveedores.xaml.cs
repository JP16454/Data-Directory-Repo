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
    /// Lógica de interacción para CatProveedores.xaml
    /// </summary>
    public partial class CatProveedores : Window
    {
        CatDireccion ag = new CatDireccion();

         

        public CatProveedores()
        {
            InitializeComponent();
             

            CatProveedoresViewModel vm = new CatProveedoresViewModel();
            DataContext = vm;

            //CatDireccionViewModel vm1 = new CatDireccionViewModel();
            //DataContext = vm1;

        }


        private void txtClave_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtClave_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtNombreProveedor_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtNombreProveedor_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtProveedor_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtProveedor_OnLostFocus(object sender, RoutedEventArgs e)
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

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Si la ventana hija -Agregar- existe, le añadimos un evento y mostramos la Ventana
                //El evento disparará cuando el usuario presione el Boton_Agregar de la Ventana Hija
                //a continuación se ejecutará el método ag_AgregarEventHandler que actualizara el Grid
                ag.AgregarEventHandler += new RoutedEventHandler(ag_AgregarEventHandler);
                ag.ShowDialog();
            }
            catch
            {
                //Si la ventana hija -Agregar- no existe, la volvemos a referenciar y le añadimos un 
                //evento y mostramos la Ventana. El evento disparará cuando el usuario presione el 
                //Boton_Agregar de la Ventana Hija, a continuación se ejecutará el método 
                //ag_AgregarEventHandler que actualizara el Grid
                ag = new CatDireccion();
                ag.AgregarEventHandler += new RoutedEventHandler(ag_AgregarEventHandler);
                ag.ShowDialog();
            }
        }


        void ag_AgregarEventHandler(object sender, RoutedEventArgs e)
        {
            //Disparado el evento se creará un nuevo objeto MyData con el nombre y apellido que se ingresaron
            //en la Ventana hija.
            //Luego se agrega al dataGridView (Informacion) el objeto datos que creamos.
            //MyData datos = new MyData() { nombre = ag.Nombre.Text.ToString(), apellido = ag.Apellido.Text.ToString() };
            //Informacion.Items.Add(datos);
        }



    }
}
