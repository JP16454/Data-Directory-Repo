using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using MessageBox = System.Windows.MessageBox;
using System.Text.RegularExpressions;
using System.ComponentModel;

using Entidades;
using Negocio;
using Navitur.Views.Main;
using Navitur.ViewModel;

namespace Navitur.VewModel
{
    public class MainWindowViewModel
    {

        public Action CloseAction { get; set; }
        private ObservableCollection<UsuarioEntidades> listaUsuarios;

        private string _SelectTextUsuario;
        private string _SelectTextPassword;
        
        public ICommand AccesoCommand { get; set; }
        public ICommand SalirCommand { get; set; }

        public string SelectTextUsuario
        {
            get { return _SelectTextUsuario; }
            set
            {
                _SelectTextUsuario = value;
                OnPropertyChanged("SelectTextUsuario");
            }
        }

        // Obtiene el Texto Capturado en el TextBox Subdivicion de Mercado
        public string SelectTextPassword
        {
            get { return _SelectTextPassword; }
            set
            {
                _SelectTextPassword = value;
                OnPropertyChanged("_SelectTextPassword");
            }
        }

        public ObservableCollection<UsuarioEntidades> ListaUsuarios
        {
            get { return listaUsuarios; }
            set
            {
                listaUsuarios = value;
                OnPropertyChanged("ListaUsuarios");
            }
        }



        #region INotifyPropertyChanged Members


        private void OnPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion




        public MainWindowViewModel()
        {
            AsociaComandosMetodos();
        }


        public void ValidarAcceso()
        {
            ListaUsuarios = null;

            UsuarioEntidades usuarios = new UsuarioEntidades();
            usuarios.Usuario = SelectTextUsuario == "" ? null : SelectTextUsuario;
            usuarios.Password = SelectTextPassword == "" ? null : SelectTextPassword;

            UsuarioBusiness Context = new UsuarioBusiness();
            List<UsuarioEntidades> Lista = Context.ValidarAcceso(usuarios);

            ListaUsuarios = new ObservableCollection<UsuarioEntidades>();

            Lista.ForEach(p =>
            {
                ListaUsuarios.Add(new UsuarioEntidades() { Usuario = p.Usuario, Password = p.Password });
            }
            );

            if (ListaUsuarios.Count() == 1)
            {
                Principal mw = new Principal();
                mw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso Invalido");
            }
        }
        








        private void CloseCommandExecute()
        {
            CloseAction();
        }

        private void AsociaComandosMetodos()
        {
            AccesoCommand = new CommandBase(p => this.ValidarAcceso());
            //CrearCommand = new CommandBase(p => this.CrearEmisoraLocal());
            //ModificarCommand = new CommandBase(p => this.ModificarEmisoraLocal());
            //EliminarCommand = new CommandBase(p => this.EliminarEmisoraLocal());
            //ConsultarCommand = new CommandBase(p => this.ConsultarEmisorasLocales());
            //LimpiarCommand = new CommandBase(p => this.Limpiar());
            SalirCommand = new CommandBase(p => this.CloseCommandExecute());

        }




    }
}
