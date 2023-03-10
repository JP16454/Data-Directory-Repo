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
    public class CatalogoAgentesDetalleViewModel : INotifyPropertyChanged
    {

        public Action CloseAction { get; set; }

        private ObservableCollection<CatAgentesDetalleEntity> listacatagentes;

        public ObservableCollection<CatAgentesDetalleEntity> ListaCatAgentes
        {
            get { return listacatagentes; }
            set
            {
                listacatagentes = value;
                OnPropertyChanged("ListaCatAgentes");
            }
        }

        public CatalogoAgentesDetalleViewModel(CatAgentesEntity objeto)
        {
            CargaListaCatAgentes(objeto);
        }

        public void CargaListaCatAgentes(CatAgentesEntity objeto)
        {
            ListaCatAgentes = null;

            List<CatAgentesDetalleEntity> ListaFiltros = CatAgentesBusiness.ConsultaAgentesAll(objeto);
            ListaCatAgentes = new ObservableCollection<CatAgentesDetalleEntity>();

            ListaFiltros.ForEach(p =>
            {
                ListaCatAgentes.Add(new CatAgentesDetalleEntity()
                {
                    IdAgente = Convert.ToInt32(p.IdAgente)
                                    ,
                    Nombre = p.Nombre
                                    ,
                    ApellidoPaterno = p.ApellidoPaterno
                                    ,
                    ApellidoMaterno = p.ApellidoMaterno
                                    ,
                    Calle = p.Calle
                                    ,
                    NumInterior = p.NumInterior
                                    ,
                    NumExterior = p.NumExterior
                                    ,
                    Colonia = p.Colonia
                                    ,
                    CodigoPostal = p.CodigoPostal
                                    ,
                    Municipio = p.Municipio
                                    ,
                    Estado = p.Estado
                                    ,
                    Pais = p.Pais
                                    ,
                    Telefono = p.Telefono
                                    ,
                    Celular = p.Celular

                });
            }
            );

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
