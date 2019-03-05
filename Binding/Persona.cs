using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class Persona :INotifyPropertyChanged
    {
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        private String apellido;
        public String Apellido
        {
            get { return apellido; }
            set
            {
                this.apellido = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Apellido"));
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
