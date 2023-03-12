using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ingenieria_en_software_2.obj
{
    public class Carpeta : ElementoBase
{
    private List<ElementoBase> elementos;

    public Carpeta(string nombre, double peso) : base(nombre, peso)
    {
        elementos = new List<ElementoBase>();
    }

    public void AgregarElemento(ElementoBase elemento)
    {
        elementos.Add(elemento);
    }

    public void AgregarElemento<T>(T elemento) where T : ElementoBase
    {
        elementos.Add(elemento);
    }
}
}