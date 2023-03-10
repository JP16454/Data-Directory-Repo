
using System;
using System.Windows;
using System.Windows.Input;

using Navitur.VewModel;



namespace Navitur.Views.Main
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Principal p = new Principal();
        public MainWindow()
        {

            InitializeComponent();

            MainWindowViewModel vm = new MainWindowViewModel();
            
            if (vm.CloseAction == null)
                DataContext = vm;
            vm.CloseAction = new Action(this.Close);
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
