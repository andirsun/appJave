using Newtonsoft.Json;
using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Options : ContentPage
    {
        public usuario estudiante;
        public List<materias> Materias=new List<materias>();
        public Options( usuario est)
        {
            //CargarMaterias();
            InitializeComponent();
            estudiante = est;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             ((NavigationPage)this.Parent).PushAsync(new asignaturas(estudiante, Materias));
            //Application.Current.MainPage = new NavigationPage(new asignaturas(estudiante,Materias));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Profile(estudiante));
            //Application.Current.MainPage = new NavigationPage(new Profile(estudiante));
        }

        public async void CargarMaterias()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/asignaturas");
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", estudiante.token);
            var response = await client.GetAsync(client.BaseAddress);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<materias>>(content);
            if (Items != null)
            {
                Materias = Items;
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new libros(estudiante));
        }
    }
}