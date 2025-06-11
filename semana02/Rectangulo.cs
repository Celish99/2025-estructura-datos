// clase
public class Rectangulo
{
    // atributos
    public double Base { get;  set; }
    public double Altura { get; set; }

    // constructor
    public Rectangulo(double Base, double Altura)
    {
        this.Base = Base;
        this.Altura = Altura;
    }

    // metodos
    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}
