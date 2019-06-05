using Prueba2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Prueba2.Views;

namespace Prueba2
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public const string BaseUrl = "http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/Autenticacion/?";
        usuario estudiante;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void BtnCallWS_Click(object sender, EventArgs e)
        {
            conexionLogincs client = new conexionLogincs();
            var usu = "usu="+user.Text ;
            var pass = "pass="+password.Text;
            var url = BaseUrl + usu +"&"+ pass;
            var result = await client.Get<usuario>(url);
            if (result != null)
            {
                if (result.valido)
                {
                    //nombre.Text = result.nombre;
                    nombre.Text ="Bienvenido "+result.nombre;
                    Console.WriteLine(nombre.Text);
                    estudiante = result;
                    //await DisplayAlert("Info Estudiante", result.ToString(), "ok");
                    Application.Current.MainPage = new NavigationPage(new Options(estudiante));
                    
                }
                else
                {
                    nombre.Text = "Ups.. Este Usuario no Es valido, Intenta de nuevo";
                }

            }
            else
            {
                nombre.Text = "Ups No se pudo Conectar Al servidor";
            }
        }
    }
}
