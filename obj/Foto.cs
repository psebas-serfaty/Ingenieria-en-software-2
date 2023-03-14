using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ingenieria_en_software_2.obj
{
    public class Foto : ElementoBase
    {
        private string dimensiones;

    public Foto(string nombre, double peso, string dimensiones) : base(nombre, peso)
    {
        this.dimensiones = dimensiones;
    }

    public string Dimensiones
    {
        get { return dimensiones; }
        set { dimensiones = value; }
    }

    }
}