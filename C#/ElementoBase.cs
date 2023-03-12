using System.Dynamic;
abstract class ElementoBase
{
    private string nombre;
    private float tamano;
  
  public abstract void ObtenerTamano()
  {
    get{return this.nombre;}
    get{return this.tamano;}
    set{return this.nombre;}
    set{return this. tamano;}
  }
}