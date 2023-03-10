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

using Navitur.Views.Main;
using Navitur.VewModel;


namespace Navitur.Views.AdministrarUsuarios
{
    /// <summary>
    /// Lógica de interacción para AdminUsuarios.xaml
    /// </summary>
    public partial class AdminUsuarios : Window
    {
        Principal p = new Principal();

        public AdminUsuarios()
        {
            InitializeComponent();

            AdminUsuariosViewModel vm = new AdminUsuariosViewModel();

            if (vm.CloseAction == null)
                DataContext = vm;
            vm.CloseAction = new Action(this.Close);
        }

        private void dgvUsuarios_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            DataGridRow rowContext = e.Row;
            if (rowContext != null)
            {
                int index = rowContext.GetIndex();
                if (index % 2 == 0)
                {
                    SolidColorBrush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    rowContext.Background = brush;
                }
                else
                {
                    SolidColorBrush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DCE8FA"));
                    rowContext.Background = brush;
                }
            }
        }


        private void txtUsuario_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtusuario = sender as TextBox;
            //usuarios.Usuario = txtusuario.Text;
        }

        private void txtUsuario_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void txtPassword_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            //var txtPassword = sender as TextBox;
            //usuarios.Password = txtPassword.Text;
        }

        private void txtPassword_OnLostFocus(object sender, RoutedEventArgs e)
        {

        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Al cerrar la ventana principal debemos validar que la referencia a la Ventana hija
            //se cierre para que el programa cierre completamente.
            p.Close();
        }





    }
}
