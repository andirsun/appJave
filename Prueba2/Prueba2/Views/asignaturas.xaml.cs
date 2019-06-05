using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Prueba2.ViewModels;

namespace Prueba2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class asignaturas : ContentPage
    {
        public const string BaseUrl = "http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/asignaturas";
        public const string token = "";
        usuario estudiante;
        List<materias> Materias;
        public asignaturas(usuario est, List<materias> mat)
        {
            InitializeComponent();
            estudiante = est;
            //Materias = mat; 
            //BtnCallWS_Click();
            BindingContext = new MateriaViewModel(estudiante);

        }

        public async void BtnCallWS_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/asignaturas");
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", estudiante.token);
            var response = await client.GetAsync(client.BaseAddress);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<materias>>(content);


            // no need to check `content` because here you work with `Items` already
            if (Items != null)
            {
                //Materias = Items;
                // Count will show you number of records deserilized
                //await DisplayAlert("mensaje", Items.Count, "ok");

               /* foreach (var materia in Items)
                {
                    lb1Materia.Text = materia.nom;
                    lb2Materia1.Text = materia.class_section;
                    lb3Materia1.Text = materia.coda;
                    lb4Materia1.Text = materia.notp;
                    foreach (var hor in materia.horario)
                    {
                        lb2Horario.Text = hor.doc;
                        lb3Horario.Text = hor.hora;
                        lb4Horario.Text = hor.dia;
                        await Task.Delay(1000);
                    }
                    //var nose = materia;
                    //await DisplayAlert("materia", nose.nom, "ok");
                    //await DisplayAlert("materia", materia.nom, "ok");

                }*/
                
            }
            /*
                        var Items = JsonConvert.DeserializeObject <List<materias>>(content);

                        if (content != null)
                        {
                            await DisplayAlert("mensaje", Items.ToString(), "ok");
                            foreach (var materia in Items)
                            {
                                await DisplayAlert("materia", , "ok");
                            }

                        else
                        {
                            errorLog.Text = "Ups No se pudo Conectar Al servidor";


                        }*/


        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView lv = (ListView)sender;
            //Horario mihorario = (Horario)lv.SelectedItem;
            //Console.WriteLine(e.SelectedItem);
            //await Navigation.PushAsync(new horario());

        }
    }

       

   
}