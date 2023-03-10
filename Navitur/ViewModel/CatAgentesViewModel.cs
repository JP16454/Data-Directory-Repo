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
using System.Runtime.CompilerServices;
using Navitur.Views.Catalogos;



namespace Navitur.ViewModel
{
    public class CatAgentesViewModel : INotifyPropertyChanged
    {
        public Action CloseAction { get; set; }

        public CatAgentesEntity objeto = new CatAgentesEntity();

        // Retorna por medio de la propiedad el valor de los Items seleccionados en los ComboBox 
        private Int32 _SelectItemMunicipio;
        private Int32 _SelectItemEstado;
        private Int32 _SelectItemPais;

        // Retorna por medio de la propiedad el texto seleccionado en los ComboBox

        private string _SelectTextIdAgente;
        private string _SelectTextNombreAgente;

        private string _SelectTextNombre;
        private string _SelectTextApePat;
        private string _SelectTextApeMat;
        private string _SelectTextCalle;
        private string _SelectTextNumInt;
        private string _SelectTextNumExt;
        private string _SelectTextColonia;
        private string _SelectTextCP;
        private string _SelectTextMunicipio;
        private string _SelectTextEstado;
        private string _SelectTextPais;
        private string _SelectTextTelefono;
        private string _SelectTextCelular;


        private ObservableCollection<CatMunicipioEntity> listaMunicipio;
        private ObservableCollection<CatEstadoEntity> listaEstado;
        private ObservableCollection<CatPaisEntity> listaPais;


        #region "Definir Comandos Para los Botones"

        public ICommand ExportarCommand { get; set; }
        public ICommand CrearCommand { get; set; }
        public ICommand ModificarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        public ICommand LimpiarCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
        public ICommand SalirCommand { get; set; }

        #endregion


        public ObservableCollection<CatMunicipioEntity> ListaMunicipio
        {
            get { return listaMunicipio; }
            set
            {
                listaMunicipio = value;
                OnPropertyChanged("ListaMunicipio");
            }
        }

        public ObservableCollection<CatEstadoEntity> ListaEstado
        {
            get { return listaEstado; }
            set
            {
                listaEstado = value;
                OnPropertyChanged("ListaEstado");
            }
        }

        public ObservableCollection<CatPaisEntity> ListaPais
        {
            get { return listaPais; }
            set
            {
                listaPais = value;
                OnPropertyChanged("ListaPais");
            }
        }


        #region "Propiedades Para Obtener el Texto Cargado en los Filtros"

        

        public string SelectTextIdAgente
        {
            get { return _SelectTextIdAgente; }
            set
            {
                _SelectTextIdAgente = value;
                OnPropertyChanged("SelectTextIdAgente");
            }
        }
        
        public string SelectTextNombreAgente
        {
            get { return _SelectTextNombreAgente; }
            set
            {
                _SelectTextNombreAgente = value;
                OnPropertyChanged("SelectTextNombreAgente");
            }
        }

        public string SelectTextNombre
        {
            get { return _SelectTextNombre; }
            set
            {
                _SelectTextNombre = value;
                OnPropertyChanged("SelectTextNombre");
            }
        }

        public string SelectTextApePat
        {
            get { return _SelectTextApePat; }
            set
            {
                _SelectTextApePat = value;
                OnPropertyChanged("SelectTextApePat");
            }
        }

        public string SelectTextApeMat
        {
            get { return _SelectTextApeMat; }
            set
            {
                _SelectTextApeMat = value;
                OnPropertyChanged("SelectTextApeMat");
            }
        }

        public string SelectTextCalle
        {
            get { return _SelectTextCalle; }
            set
            {
                _SelectTextCalle = value;
                OnPropertyChanged("SelectTextCalle");
            }
        }

        public string SelectTextNumInt
        {
            get { return _SelectTextNumInt; }
            set
            {
                _SelectTextNumInt = value;
                OnPropertyChanged("SelectTextNumInt");
            }
        }

        public string SelectTextNumExt
        {
            get { return _SelectTextNumExt; }
            set
            {
                _SelectTextNumExt = value;
                OnPropertyChanged("SelectTextNumExt");
            }
        }

        public string SelectTextColonia
        {
            get { return _SelectTextColonia; }
            set
            {
                _SelectTextColonia = value;
                OnPropertyChanged("SelectTextColonia");
            }
        }

        public string SelectTextCP
        {
            get { return _SelectTextCP; }
            set
            {
                _SelectTextCP = value;
                OnPropertyChanged("SelectTextCP");
            }
        }

        public string SelectTextMunicipio
        {
            get { return _SelectTextMunicipio; }
            set
            {
                _SelectTextMunicipio = value;
                OnPropertyChanged("SelectTextMunicipio");
            }
        }

        public string SelectTextEstado
        {
            get { return _SelectTextEstado; }
            set
            {
                _SelectTextEstado = value;
                OnPropertyChanged("SelectTextEstado");


            }
        }

        public string SelectTextPais
        {
            get { return _SelectTextPais; }
            set
            {
                _SelectTextPais = value;
                OnPropertyChanged("SelectTextPais");
            }
        }

        public string SelectTextTelefono
        {
            get { return _SelectTextTelefono; }
            set
            {
                _SelectTextTelefono = value;
                OnPropertyChanged("SelectTextTelefono");
            }
        }

        public string SelectTextCelular
        {
            get { return _SelectTextCelular; }
            set
            {
                _SelectTextCelular = value;
                OnPropertyChanged("SelectTextCelular");
            }
        }

        #endregion


        #region "Propiedades Para Obtener el Item de los Filtros de Tipo ComboBox"
        public Int32 SelectItemMunicipio
        {
            get { return _SelectItemMunicipio; }
            set
            {
                _SelectItemMunicipio = value;
                OnPropertyChanged("SelectItemMunicipio");
            }
        }

        public Int32 SelectItemEstado
        {
            get { return _SelectItemEstado; }
            set
            {
                _SelectItemEstado = value;
                OnPropertyChanged("SelectItemEstado");

                CargaListaMunicipio();
                OnPropertyChanged("SelectItemMunicipio");

            }
        }

        public Int32 SelectItemPais

        {
            get { return _SelectItemPais; }
            set
            {
                _SelectItemPais = value;
                OnPropertyChanged("SelectItemPais");
            }
        }

        #endregion


        // Declaramos el constructor y cargamos los catalogos en los combobox  

        public CatAgentesViewModel()
        {
            AsociaComandosMetodos();

            CargaListaPais();
            CargaListaEstado();
            //CargaListaMunicipio();

        }

        // Consultamos el catalogo de Municipios
        public void CargaListaMunicipio()
        {
            ListaMunicipio = null;

            List<CatMunicipioEntity> ListaFiltros = CatMunicipioBusiness.ConsultaMunicipiosAll(Convert.ToInt32(SelectItemEstado));
            ListaMunicipio = new ObservableCollection<CatMunicipioEntity>();

            ListaFiltros.ForEach(p =>
                                   {
                                       ListaMunicipio.Add(new CatMunicipioEntity() { IdMunicipio = Convert.ToInt32(p.IdMunicipio), Descripcion = p.Descripcion });
                                   }
                                );
        }

        // Consultamos el catalogo de Estados
        public void CargaListaEstado()
        {
            ListaEstado = null;

            List<CatEstadoEntity> ListaFiltros = CatEstadoBusiness.ConsultaEstadoAll();
            ListaEstado = new ObservableCollection<CatEstadoEntity>();

            ListaFiltros.ForEach(p =>
            {
                ListaEstado.Add(new CatEstadoEntity() { IdEstado = Convert.ToInt32(p.IdEstado), NombreEstado = p.NombreEstado });
            }
                                );

        }

        // Consultamos el catalogo de Paises
        public void CargaListaPais()
        {
            ListaPais = null;

            List<CatPaisEntity> ListaFiltros = CatPaisBusiness.ConsultaPaisAll();
            ListaPais = new ObservableCollection<CatPaisEntity>();

            ListaFiltros.ForEach(p =>
            {
                ListaPais.Add(new CatPaisEntity() { IdPais = Convert.ToInt32(p.IdPais), NombrePais = p.NombrePais });
            }
                                );
        }

        // Cerramos la Pantalla
        private void CloseCommandExecute()
        {
            CloseAction();
        }

        // Asociamos los comandos a los controles
        private void AsociaComandosMetodos()
        {

            //ExportarCommand = new CommandBase(p => this.Exportar());
            CrearCommand = new CommandBase(p => this.GuardarCatalogoAgentes());
            //ModificarCommand = new CommandBase(p => this.ModificarEmisoraLocal());
            //EliminarCommand = new CommandBase(p => this.EliminarEmisoraLocal());
            ConsultarCommand = new CommandBase(p => this.ConsultaCatalogo());
            LimpiarCommand = new CommandBase(p => this.Limpiar());
            SalirCommand = new CommandBase(p => this.CloseCommandExecute());

        }


        public void ConsultaCatalogo()
        {
            objeto.IdAgente = SelectTextIdAgente == "" ? null : SelectTextIdAgente; 
            objeto.Nombre = SelectTextNombreAgente == "" ? null : SelectTextNombreAgente;
            //string strIdAgente = SelectTextIdAgente;


            CatalogoAgentesDetalle Ventana = new CatalogoAgentesDetalle(objeto);
            Ventana.Show();

            SelectTextIdAgente = string.Empty;
            SelectTextNombreAgente = string.Empty;

        }


        // Guardamos el catalogo de Agentes
        public bool GuardarCatalogoAgentes()
        {
            bool Respuesta = false;

            if (!GuardarCatalogoDireccion())
            {
                MessageBox.Show("Se genero un error al guardar la direccion");
                return false;
            }
            else
            {
                CatAgentesEntity ObjetoAgentes = new CatAgentesEntity();

                ObjetoAgentes.Nombre = SelectTextNombre == "" ? null : SelectTextNombre;
                ObjetoAgentes.ApellidoPaterno = SelectTextApePat == "" ? null : SelectTextApePat;
                ObjetoAgentes.ApellidoMaterno = SelectTextApeMat == "" ? null : SelectTextApeMat;
                ObjetoAgentes.Telefono = SelectTextTelefono == "" ? null : SelectTextTelefono;
                ObjetoAgentes.Celular = SelectTextCelular == "" ? null : SelectTextCelular;

                Respuesta = CatAgentesBusiness.InsertarAgentes(ObjetoAgentes);
                if(Respuesta == false)
                {
                    MessageBox.Show("Se genero un error al guardar agentes");
                    //Respuesta = false;
                }
            }

            return Respuesta;
        }


        // Guardamos el Catalogo de Direcciones
        public bool GuardarCatalogoDireccion()
        {
            bool Respuesta = false;

            CatDireccionEntity ObjetoDireccion = new CatDireccionEntity();

            ObjetoDireccion.Calle = SelectTextCalle == "" ? null: SelectTextCalle;
            ObjetoDireccion.NumInterior = Convert.ToInt32(SelectTextNumInt.ToString()) == 0 ? 0 : Convert.ToInt32(SelectTextNumInt.ToString());
            ObjetoDireccion.NumExterior = Convert.ToInt32(SelectTextNumExt.ToString()) == 0 ? 0 : Convert.ToInt32(SelectTextNumExt.ToString());
            ObjetoDireccion.Colonia = SelectTextColonia == "" ? null : SelectTextColonia;
            ObjetoDireccion.CodigoPostal = SelectTextCP == "" ? null : SelectTextCP;
            ObjetoDireccion.IdMunicipio = Convert.ToInt32(SelectItemMunicipio) == 0 ? 0 : Convert.ToInt32(SelectItemMunicipio);
            ObjetoDireccion.IdEstado = Convert.ToInt32(SelectItemEstado) == 0 ? 0 : Convert.ToInt32(SelectItemEstado);
            ObjetoDireccion.IdPais = Convert.ToInt32(SelectItemPais) == 0 ? 0 : Convert.ToInt32(SelectItemPais);

            Respuesta = CatDireccionBusiness.InsertarDireccion(ObjetoDireccion);

            return Respuesta;
        }


        private void Limpiar()
        {

            SelectTextNombre = string.Empty;
            SelectTextApePat = string.Empty;
            SelectTextApeMat = string.Empty;
            SelectTextTelefono = string.Empty;
            SelectTextCelular = string.Empty;

            SelectTextCalle = string.Empty;
            SelectTextNumInt= string.Empty;
            SelectTextNumExt = string.Empty;
            SelectTextColonia = string.Empty;
            SelectTextCP = string.Empty;
            SelectItemMunicipio = -1;
            SelectItemEstado = -1;
            SelectItemPais = -1;

        }

        



        #region INotifyPropertyChanged Members


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(String propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        #endregion


    }


}
    