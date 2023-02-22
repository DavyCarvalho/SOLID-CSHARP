/// <summary>
/// 
/// O Princípio estabelece que as classes derivadas devem ser substituíveis por suas classes base. 
/// Isso significa que uma classe filha deve ser capaz de substituir sua classe pai sem 
/// que isso afete o comportamento do programa. 
/// Abaixo um exemplo de código que segue este princípio:
/// 
/// </summary>

using System;

namespace SOLID._03___LiskovSubstitutionPrinciple
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("To vuaaaano!");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins não podem voar!");
        }
    }

    public class FlyingBird
    {
        private readonly Bird _bird;

        public FlyingBird(Bird bird)
        {
            _bird = bird;
        }

        public void Fly()
        {
            _bird.Fly();
        }
    }
}

///<summary>
///
/// Neste exemplo, a classe Penguin é uma subclasse da classe Bird. No entanto, pinguins não podem voar. 
/// Para garantir que essa restrição seja respeitada, a classe Penguin sobrescreve o método Fly() e lança uma exceção. 
/// A classe FlyingBird aceita um objeto do tipo Bird em seu construtor e chama o método Fly(). 
/// Como o método Fly() é virtual na classe Bird, ele pode ser sobrescrito na classe Penguin 
/// sem quebrar o comportamento da classe FlyingBird.
/// 
/// </summary>