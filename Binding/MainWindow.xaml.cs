using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> ListaPersonas { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ListaPersonas = new ObservableCollection<Persona>();
            ListaPersonas.Add(new Persona("Elver", "Galarga"));
            ListaPersonas.Add(new Persona("Mary", "Conazo"));
            this.DataContext = this; //define el contexto de los datos 

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            ListaPersonas.Add(new Persona("Lisa", "Ann"));
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {

            ListaPersonas.RemoveAt(0);
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            ListaPersonas.ElementAt(0).Nombre = "Lomito";
            ListaPersonas.ElementAt(0).Apellido = "Lito";
        }
    }
}
