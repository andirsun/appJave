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
    public partial class libros : ContentPage
    {
        public libros(usuario est)
        {
            InitializeComponent();
        }
    }
}