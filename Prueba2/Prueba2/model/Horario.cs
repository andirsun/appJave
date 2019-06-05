using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Prueba2.model
{
    public class Horario : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        [JsonProperty("feci")]
        private string fechaInicio;
        public string FechaInicio { get { return fechaInicio; } set { fechaInicio = value; OnPropertyChanged(); } }
        [JsonProperty("hora")]
        private string horaH;
        public string HoraH { get { return horaH; } set { horaH = value; OnPropertyChanged(); } }
        [JsonProperty("saln")]
        private string salon;
        public string Salon { get { return salon; } set { salon = value; OnPropertyChanged(); } }
        [JsonProperty("fecf")]
        private string fechaFin;
        public string FechaFin { get { return fechaFin; } set { fechaFin = value; OnPropertyChanged(); } }
        [JsonProperty("doc")]
        private string docente;
        public string Docente { get { return docente; } set { docente = value; OnPropertyChanged(); } }
        [JsonProperty("dia")]
        private string diaH;
        public string DiaH { get { return diaH; } set { diaH = value; OnPropertyChanged(); } }
    }
}
