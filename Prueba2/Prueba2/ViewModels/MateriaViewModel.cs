using Prueba2.model;
using System;
using System.Collections.Generic;
using System.Text;
using Prueba2.ViewModels;
using Prueba2.Servicios;

namespace Prueba2.ViewModels
{
    public class MateriaViewModel : materias
    {
        private List<materias> Materias = new List<materias>();
        conexionAsignaturas SeriviceMaterias = new conexionAsignaturas();

        public MateriaViewModel(usuario est)
        {
            this.CargarMaterias(est);
        }

        public List<materias > Mmaterias
        {
            get { return Materias; }
            set { Materias = value;
                OnPropertyChanged();
            }
        }
         private async void CargarMaterias(usuario estudiante)
        {
            Mmaterias = await SeriviceMaterias.getMaterias(estudiante);
        }
    }
}
