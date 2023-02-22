/// <summary>
/// 
/// O Princípio Aberto-Fechado (OCP) estabelece que uma classe deve ser 
/// aberta para extensão, mas fechada para modificação. 
/// Isso significa que a classe deve permitir que novas funcionalidades 
/// sejam adicionadas sem que o código existente precise ser alterado. 
/// Abaixo um exemplo de código que segue este princípio:
/// 
/// </summary>

using System;

namespace SOLID._02___OpenClosedPrinciple
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}

/// <sumary>
/// 
/// Neste exemplo, a classe AreaCalculator é aberta para extensão, pois é possível adicionar 
/// novas formas geométricas que implementam a interface IShape sem precisar modificar o código existente. 
/// Por exemplo, se quisermos adicionar uma classe Triangle que também implementa IShape, 
/// basta criar a nova classe e implementar o método CalculateArea(). 
/// O restante do código existente não precisará ser alterado.
/// 
/// </sumary>
