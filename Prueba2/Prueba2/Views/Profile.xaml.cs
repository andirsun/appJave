using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        usuario estudiante;
        public Profile(usuario est)
        {
            InitializeComponent();
            estudiante = est;
            MostrarUsuario();
        }
        
        private  void MostrarUsuario()
        {
            lbNombre.Text = estudiante.nombre;
            lbapellidos.Text = estudiante.apellido;
            //lbsemestre.Text = estudiante.periodo;
            lbIdestudiante.Text = estudiante.emplid;
            lbActivo.Text = estudiante.email;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso","Desea Cerrar Sesion", "ok");
            Application.Current.MainPage = new MainPage();
        }
    }
}