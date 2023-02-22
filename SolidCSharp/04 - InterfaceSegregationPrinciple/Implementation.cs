///<summary>
///
/// O Princípio da Segregação de Interface (ISP) estabelece que uma classe 
/// deve depender apenas das interfaces que ela usa. Isso significa que uma 
/// classe não deve ser forçada a implementar métodos que não usa.
/// Abaixo um exemplo de código que segue este princípio:
/// 
/// </summary>

using System;

namespace SOLID._04___InterfaceSegregationPrinciple
{
    public interface ICar
    {
        void Accelerate();
        void Brake();
    }

    public interface IAirplane
    {
        void TakeOff();
        void Land();
    }

    public class Car : ICar
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }

        public void Brake()
        {
            Console.WriteLine("Braking...");
        }
    }

    public class Airplane : IAirplane
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off...");
        }

        public void Land()
        {
            Console.WriteLine("Landing...");
        }
    }

    public class CarAirplane : ICar, IAirplane
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public CarAirplane(Car car, Airplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Accelerate()
        {
            _car.Accelerate();
        }

        public void Brake()
        {
            _car.Brake();
        }

        public void TakeOff()
        {
            _airplane.TakeOff();
        }

        public void Land()
        {
            _airplane.Land();
        }
    }
}

///<summary>
///
/// Neste exemplo, as interfaces ICar e IAirplane têm apenas os métodos que são relevantes 
/// para cada tipo de veículo. As classes Car e Airplane implementam apenas as interfaces 
/// que são relevantes para elas. A classe CarAirplane é uma classe híbrida que implementa 
/// ambas as interfaces, mas delega a implementação dos métodos relevantes para as classes 
/// Car e Airplane. Como resultado, a classe CarAirplane não precisa implementar métodos 
/// que não são relevantes para ela.
/// 
/// </summary>