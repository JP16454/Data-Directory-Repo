#pragma checksum "..\..\..\Views\AdminUsuarios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E2AA22CA1EBD5BC9CDD23EF690BBB379687CDE63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AppPresentacion.Views.AdministrarUsuarios;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AppPresentacion.Views.AdministrarUsuarios {
    
    
    /// <summary>
    /// AdminUsuarios
    /// </summary>
    public partial class AdminUsuarios : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 114 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBienvenido;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsuario;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPassword;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPerfil;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuario;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\Views\AdminUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPerfil;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Navitur;component/views/adminusuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AdminUsuarios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblBienvenido = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblPerfil = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtUsuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 196 "..\..\..\Views\AdminUsuarios.xaml"
            this.txtUsuario.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtUsuario_OnPreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 197 "..\..\..\Views\AdminUsuarios.xaml"
            this.txtUsuario.LostFocus += new System.Windows.RoutedEventHandler(this.txtUsuario_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 210 "..\..\..\Views\AdminUsuarios.xaml"
            this.txtPassword.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtPassword_OnPreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 211 "..\..\..\Views\AdminUsuarios.xaml"
            this.txtPassword.LostFocus += new System.Windows.RoutedEventHandler(this.txtPassword_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbPerfil = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

