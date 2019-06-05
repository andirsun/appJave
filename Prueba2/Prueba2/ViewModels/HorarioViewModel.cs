using Prueba2.model;
using Prueba2.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba2.ViewModels
{
    public class HorarioViewModel : Horario
    {
        private List<Horario> miHorario = new List<Horario>();
        conexionAsignaturas SeriviceMaterias = new conexionAsignaturas();
        public HorarioViewModel(usuario est)
        {
            this.CargarHorario(est);
        }
        public List<Horario> MiHorario
        {
            get { return miHorario; }
            set
            {
                miHorario = value;
                OnPropertyChanged();
            }
        }
        private async void CargarHorario(usuario estudiante)
        {
            miHorario = await SeriviceMaterias.getHorario(estudiante);
        }
    }
}
