using System;
using System.Collections.Generic;
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
        public List<Persona> ListaPersonas { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ListaPersonas = new List<Persona>();
            ListaPersonas.Add(new Persona("Elver", "Galarga"));
            ListaPersonas.Add(new Persona("Mary", "Conazo"));
            this.DataContext = this; //define el contexto de los datos 

        }
    }
}
