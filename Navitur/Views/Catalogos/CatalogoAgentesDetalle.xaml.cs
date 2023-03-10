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
using Entidades;
using Negocio;

namespace Navitur.Views.Catalogos
{
    /// <summary>
    /// Lógica de interacción para CatalogoAgentesDetalle.xaml
    /// </summary>
    public partial class CatalogoAgentesDetalle : Window
    {
        public CatalogoAgentesDetalle(CatAgentesEntity objeto)
        {
            InitializeComponent();

            CatalogoAgentesDetalleViewModel vm = new CatalogoAgentesDetalleViewModel(objeto);
            DataContext = vm;
        }
    }
}
