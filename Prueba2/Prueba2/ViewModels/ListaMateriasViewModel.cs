using Newtonsoft.Json;
using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace Prueba2.ViewModels
{
    public class ListaMateriasViewModel : materias
    {
        public ObservableCollection<materias> ListaMaterias { get; set; }
        public List<materias> Materias { get; set; }
        public usuario estudiante;
        public ListaMateriasViewModel(usuario est)
        {
            estudiante = est;
            CargarMaterias();
            ListaMaterias = new ObservableCollection<materias>();
           /* ListaMaterias.Add(new materias()
            {
                nom = "moviles",
                class_section =
                "A",
                coda = "3134",
                notp = "4.0"
            });
            foreach(var Mat in Materias)
            {
                ListaMaterias.Add(Mat);
            }*/

        }
        public async void  CargarMaterias()
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
    }
}
