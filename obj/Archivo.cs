using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ingenieria_en_software_2.obj
{
    public class Archivo : ElementoBase
{
    private string extension;

    public Archivo(string nombre, double peso, string extension) : base(nombre, peso)
    {
        this.extension = extension;
    }

    public string Extension
    {
        get { return extension; }
        set { extension = value; }
    }
}
}