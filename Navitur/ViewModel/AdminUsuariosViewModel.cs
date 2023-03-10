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
using Navitur.VewModel;
using Navitur.ViewModel;


namespace Navitur.VewModel
{
    public class AdminUsuariosViewModel
    {
        public Action CloseAction { get; set; }
        private ObservableCollection<UsuarioEntidades> listaUsuarios;
        private ObservableCollection<PrivilegioEntidades> listaPerfiles;
        

        private string _SelectTextUsuario;
        private string _SelectTextPassword;
        private string _SelectTextPerfil;

        public ICommand AccesoCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
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

        public string SelectTextPerfil
        {
            get { return _SelectTextPerfil; }
            set
            {
                _SelectTextPerfil = value;
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

        public ObservableCollection<PrivilegioEntidades> ListaPerfiles
        {
            get { return listaPerfiles; }
            set
            {
                listaPerfiles = value;
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


        public AdminUsuariosViewModel()
        {
            AsociaComandosMetodos();
            ConsultaUsuariosAll();
        }


        private void CloseCommandExecute()
        {
            CloseAction();
        }

        private void AsociaComandosMetodos()
        {
            ConsultarCommand = new CommandBase(p => this.ConsultaUsuariosAll());

            //AccesoCommand = new CommandBase(p => this.ConsultaUsuariosAll());
            //CrearCommand = new CommandBase(p => this.CrearEmisoraLocal());
            //ModificarCommand = new CommandBase(p => this.ModificarEmisoraLocal());
            //EliminarCommand = new CommandBase(p => this.EliminarEmisoraLocal());
            //ConsultarCommand = new CommandBase(p => this.ConsultarEmisorasLocales());
            //LimpiarCommand = new CommandBase(p => this.Limpiar());
            SalirCommand = new CommandBase(p => this.CloseCommandExecute());

        }



        private void CargaInicialComboBox()
        {
            ListaPerfiles = null;

            //SelectItemDataGrid = new EmisorasLocales();

            //CargaLogController();
            //AsociaComandosMetodos();

            ConsultaDatosPerfil();
        }


        public void ConsultaUsuariosAll()
        {
            ListaUsuarios = null;
            UsuarioEntidades usuarios = new UsuarioEntidades();
            UsuarioBusiness Context = new UsuarioBusiness();
            List<UsuarioEntidades> Lista = Context.ConsultaUsuariosAll();

            ListaUsuarios = new ObservableCollection<UsuarioEntidades>();


            Lista.ForEach(p =>
            {
                ListaUsuarios.Add(new UsuarioEntidades()
                {
                    IdUsuario = p.IdUsuario,
                    NivelUsuario = p.NivelUsuario,
                    Usuario = p.Usuario,
                    Password = p.Password,
                    Nombre = p.Nombre,
                    Estatus = p.Estatus
                });
            }
            );


        }


        public void ConsultaDatosPerfil()
        {


        }






    }
}
