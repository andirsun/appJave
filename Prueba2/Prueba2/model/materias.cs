using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Prueba2.model
{
    public class materias : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [JsonProperty("nom")]
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; OnPropertyChanged(); } }
        [JsonProperty("peri")]
        private string periodo;
        public string Periodo { get { return periodo; } set { periodo = value; OnPropertyChanged(); } }
        [JsonProperty("coda")]
        private string codAsignatura;
        public string CodAsignatura { get { return codAsignatura; } set { codAsignatura = value; OnPropertyChanged(); } }
        [JsonProperty("Strm")]
        private string strma;
        public string Strma { get { return strma; } set { strma = value; OnPropertyChanged(); } }
        [JsonProperty("notp")]
        private string notaPonderada;
        public string NotaPonderada { get { return notaPonderada; } set { notaPonderada = value; OnPropertyChanged(); } }
        [JsonProperty("porci")]
        private string porcim;
        public string Porcim { get { return porcim; } set { porcim = value; OnPropertyChanged(); } }
        [JsonProperty("class_section")]
        private string clase_section;
        public string Clase_section { get { return clase_section; } set { clase_section = value; OnPropertyChanged(); } }
        [JsonProperty("crse_id")]
        private string curso_id;
        public string Curso_id { get { return curso_id; } set { curso_id = value; OnPropertyChanged(); } }
        [JsonProperty("hoario")]
        private List<Horario> horariom;
        public List<Horario> Horariom { get { return horariom; } set { horariom = value; OnPropertyChanged(); } }
        [JsonProperty("notas")]
        private List<object> notasParciales;
        public List<object> NotasParciales { get { return notasParciales; } set { notasParciales = value; OnPropertyChanged(); } }
        [JsonProperty("parciales")]
        private List<object> parcialesArr;
        public List<object> ParcialesArr { get { return parcialesArr; } set { parcialesArr = value; OnPropertyChanged(); } }
    }
    /*public class Horario : INotifyPropertyChanged
    {
        [JsonProperty("feci")]
        private string fechaInicio;
        public string FechaInicio { get { return fechaInicio; } set { fechaInicio = value; OnPropertyChanged(); } }
        [JsonProperty("hora")]
        private string horaH;
        public string HoraH{ get { return horaH; } set { horaH = value; OnPropertyChanged(); } }
        [JsonProperty("saln")]
        private string salon;
        public string Salon { get { return salon; } set { salon = value; OnPropertyChanged(); } }
        [JsonProperty("fecf")]
        private string fechaFin;
        public string FechaFin { get { return fechaFin; } set { fechaFin = value; OnPropertyChanged(); } }
        [JsonProperty("doc")]
        private string docente;
        public string Docente{ get { return docente; } set { docente = value; OnPropertyChanged(); } }
        [JsonProperty("dia")]
        private string diaH;
        public string DiaH{ get { return diaH; } set { diaH = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }*/
}
