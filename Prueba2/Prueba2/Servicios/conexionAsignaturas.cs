using Newtonsoft.Json;
using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Servicios
{
    public class conexionAsignaturas
    {
        private readonly HttpClient client;
        public const string Base_url = "http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2";
        public const string Materia_Url = "/asignaturas"; 

        public conexionAsignaturas()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
        }
        public async Task<List<materias>> getMaterias(usuario estudiante)
        {
            string content = "";
            var url = Base_url + Materia_Url;
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", estudiante.token);
            content = await client.GetStringAsync(url);
            List<materias> Materias = JsonConvert.DeserializeObject<List<materias>>(content);
            return Materias;

        }
        public async Task<List<Horario>> getHorario(usuario estudiante)
        {
            string content = "";
            var url = Base_url + Materia_Url;
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", estudiante.token);
            content = await client.GetStringAsync(url);
            List<Horario> Horario = JsonConvert.DeserializeObject<List<Horario>>(content);
            Console.WriteLine( Horario);
            return Horario;

        }
    }
}
