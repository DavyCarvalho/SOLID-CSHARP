/// <summary>
/// 
/// O Princípio da Responsabilidade Única (SRP) estabelece que uma classe deve ter 
/// apenas uma única responsabilidade, ou seja, deve fazer apenas uma coisa.
/// Abaixo um exemplo de código que segue este princípio:
/// 
/// </summary>

namespace SOLID.SingleResponsabilityPrinciple
{
    public class Customer
    { }

    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            _customerRepository.Remove(customer);
        }
    }

    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Remove(Customer customer);
    }
}

/// <summary>
/// 
/// No exemplo dado, a classe CustomerService é responsável apenas por lidar com 
/// operações relacionadas a clientes, como adicionar e remover clientes. A parte do 
/// código que interage com o banco de dados está separada em uma interface chamada 
/// ICustomerRepository, que é adicionada à classe CustomerService através do seu construtor. 
/// Isso permite que a classe CustomerService se concentre apenas em suas responsabilidades, 
/// enquanto outras classes podem lidar com as operações do banco de dados.
/// 
/// </summary>
