public abstract class ElementoBase
{
    protected string nombre;
    protected double peso;

    public ElementoBase(string nombre, double peso)
    {
        this.nombre = nombre;
        this.peso = peso;
    }

    public string Nombre
    {
        get { return nombre;}
        set { nombre = value;}
    }

    public double Peso
    {
        get { return peso;}
        set { peso = value;}
    }
    public virtual double ObtenerTamaño()
    {
        return nombre.Length;
    }


}