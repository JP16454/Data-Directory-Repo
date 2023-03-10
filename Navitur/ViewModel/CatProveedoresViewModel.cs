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
    public class CatProveedoresViewModel : INotifyPropertyChanged
    {
        public Action CloseAction { get; set; }
     
        public CatProveedoresEntity objeto = new CatProveedoresEntity();
        //public CatDireccionViewModel direccionvm = new CatDireccionViewModel();

        // Retorna por medio de la propiedad el valor de los Items seleccionados en los ComboBox 
        private Int32 _SelectItemMunicipio;
        private Int32 _SelectItemEstado;
        private Int32 _SelectItemPais;
        private Int32 _SelectItemFormaPago;

        // Retorna por medio de la propiedad el texto seleccionado en los ComboBox

        private string _SelectTextIdProveedor;
        private string _SelectTextNombreProveedor;

        private string _SelectTextProveedor;
        private string _SelectTextRazonSocial;
        private string _SelectTextRFC;
        private string _SelectTextCalle;
        private string _SelectTextNumInt;
        private string _SelectTextNumExt;
        private string _SelectTextColonia;
        private string _SelectTextCP;
        private string _SelectTextMunicipio;
        private string _SelectTextEstado;
        private string _SelectTextPais;
        private string _SelectTextTelefono;
        private string _SelectTextEmail;
        private string _SelectTextComision;
        private string _SelectTextIdFormaPago;
        private string _SelectTextObservaciones;

        private ObservableCollection<CatMunicipioEntity> listaMunicipio;
        private ObservableCollection<CatEstadoEntity> listaEstado;
        private ObservableCollection<CatPaisEntity> listaPais;
        private ObservableCollection<CatFormaPagoEntity> listaFormaPago;


        #region "Definir Comandos Para los Botones"
        public ICommand ExportarCommand { get; set; }
        public ICommand CrearCommand { get; set; }
        public ICommand ModificarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        public ICommand LimpiarCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
        public ICommand SalirCommand { get; set; }

        public ICommand NuevoCommand { get; set; }
        

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

        public ObservableCollection<CatFormaPagoEntity> ListaFormaPago
        {
            get { return listaFormaPago; }
            set
            {
                listaFormaPago = value;
                OnPropertyChanged("ListaFormaPago");
            }
        }


        #region "Propiedades Para Obtener el Texto Cargado en los Filtros"

        public string SelectTextIdProveedor
        {
            get { return _SelectTextIdProveedor; }
            set
            {
                _SelectTextIdProveedor = value;
                OnPropertyChanged("SelectTextIdProveedor");
            }
        }

        public string SelectTextNombreProveedor
        {
            get { return _SelectTextNombreProveedor; }
            set
            {
                _SelectTextNombreProveedor = value;
                OnPropertyChanged("SelectTextNombreProveedor");
            }
        }

        public string SelectTextProveedor
        {
            get { return _SelectTextProveedor; }
            set
            {
                _SelectTextProveedor = value;
                OnPropertyChanged("SelectTextProveedor");
            }
        }

        public string SelectTextRazonSocial
        {
            get { return _SelectTextRazonSocial; }
            set
            {
                _SelectTextRazonSocial = value;
                OnPropertyChanged("SelectTextRazonSocial");
            }
        }

        public string SelectTextRFC
        {
            get { return _SelectTextRFC; }
            set
            {
                _SelectTextRFC = value;
                OnPropertyChanged("SelectTextRFC");
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

        public string SelectTextEmail
        {
            get { return _SelectTextEmail; }
            set
            {
                _SelectTextEmail = value;
                OnPropertyChanged("SelectTextEmail");
            }
        }

        public string SelectTextComision
        {
            get { return _SelectTextComision; }
            set
            {
                _SelectTextComision = value;
                OnPropertyChanged("SelectTextComision");
            }
        }

        public string SelectTextIdFormaPago
        {
            get { return _SelectTextIdFormaPago; }
            set
            {
                _SelectTextIdFormaPago = value;
                OnPropertyChanged("SelectTextIdFormaPago");
            }
        }

        public string SelectTextObservaciones
        {
            get { return _SelectTextObservaciones; }
            set
            {
                _SelectTextObservaciones = value;
                OnPropertyChanged("SelectTextObservaciones");
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


        public Int32 SelectItemFormaPago

        {
            get { return _SelectItemFormaPago; }
            set
            {
                _SelectItemFormaPago = value;
                OnPropertyChanged("SelectItemFormaPago");
            }
        }

        #endregion


        public CatProveedoresViewModel()
        {
            AsociaComandosMetodos();

            CargaListaPais();
            CargaListaEstado();
            //CargaListaMunicipio();
            CargaListaFormaPago();

            //CatDireccionViewModel vm1 = new CatDireccionViewModel();
            //DataContext = vm1;
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

        public void CargaListaFormaPago()
        {
            ListaFormaPago = null;
             
            List<CatFormaPagoEntity> ListaFiltros = CatFormaPagoBusiness.ConsultaFormaPagoAll();
            ListaFormaPago = new ObservableCollection<CatFormaPagoEntity>();

            ListaFiltros.ForEach(p =>
            {
                ListaFormaPago.Add(new CatFormaPagoEntity() { IdFormaPago = Convert.ToInt32(p.IdFormaPago), FormaPago = p.FormaPago });
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
            CrearCommand = new CommandBase(p => this.GuardarCatalogoProveedores());
            //ModificarCommand = new CommandBase(p => this.ModificarEmisoraLocal());
            //EliminarCommand = new CommandBase(p => this.EliminarEmisoraLocal());
            ConsultarCommand = new CommandBase(p => this.ConsultaCatalogo());
            LimpiarCommand = new CommandBase(p => this.Limpiar());
            SalirCommand = new CommandBase(p => this.CloseCommandExecute());
            NuevoCommand = new CommandBase(p => this.Nuevo());

        }

        private void Nuevo()
        {

            CatDireccion Vista = new CatDireccion();
            Vista.ShowDialog();            
        }



        public void ConsultaCatalogo()
        {
            objeto.IdProveedor = SelectTextIdProveedor == "" ? null : SelectTextIdProveedor;
            objeto.Proveedor = SelectTextNombreProveedor == "" ? null : SelectTextNombreProveedor;
            //string strIdAgente = SelectTextIdAgente;
            
            //CatalogoAgentesDetalle Ventana = new CatalogoAgentesDetalle(objeto);
            //Ventana.Show();

            SelectTextIdProveedor = string.Empty;
            SelectTextNombreProveedor = string.Empty;

        }


        // Guardamos el catalogo de Agentes
        public bool GuardarCatalogoProveedores()
        {
            bool Respuesta = false;

            if (!GuardarCatalogoDireccion())
            {
                MessageBox.Show("Se genero un error al guardar la direccion");
                return false;
            }
            else
            {

                CatProveedoresEntity ObjetoProveedor = new CatProveedoresEntity();

                ObjetoProveedor.Proveedor = SelectTextProveedor == "" ? null : SelectTextProveedor;
                ObjetoProveedor.RazonSocial = SelectTextRazonSocial == "" ? null : SelectTextRazonSocial;
                ObjetoProveedor.RFC = SelectTextRFC == "" ? null : SelectTextRFC;
                ObjetoProveedor.Telefono = SelectTextTelefono == "" ? null : SelectTextTelefono;
                ObjetoProveedor.Email = SelectTextEmail == "" ? null : SelectTextEmail;
                ObjetoProveedor.Comision = SelectTextComision == "" ? null : SelectTextComision;
                ObjetoProveedor.IdFormaPago = Convert.ToInt32(SelectItemFormaPago) == 0 ? 0 : Convert.ToInt32(SelectItemFormaPago);
                ObjetoProveedor.Observaciones = SelectTextObservaciones == "" ? null : SelectTextObservaciones;

                Respuesta = CatProveedoresBusiness.InsertarProveedores(ObjetoProveedor);
                if (Respuesta == false)
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

            ObjetoDireccion.Calle = SelectTextCalle == "" ? null : SelectTextCalle;
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
            SelectTextProveedor = string.Empty;
            SelectTextRazonSocial = string.Empty;
            SelectTextRFC = string.Empty;
            SelectTextTelefono = string.Empty;
            SelectTextEmail = string.Empty;
            SelectTextComision = string.Empty;
            SelectTextObservaciones = string.Empty;

            SelectTextCalle = string.Empty;
            SelectTextNumInt = string.Empty;
            SelectTextNumExt = string.Empty;
            SelectTextColonia = string.Empty;
            SelectTextCP = string.Empty;

            SelectItemMunicipio = -1;
            SelectItemEstado = -1;
            SelectItemPais = -1;
            SelectItemFormaPago = -1;

        }


        #region INotifyPropertyChanged Members


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion 



    }
}
