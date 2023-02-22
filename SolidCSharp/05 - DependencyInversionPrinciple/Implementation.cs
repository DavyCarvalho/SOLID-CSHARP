///<summary>
///
/// O Princípio da Inversão de Dependência (DIP) estabelece que as 
/// classes de alto nível não devem depender de classes de baixo nível diretamente. 
/// Em vez disso, ambas devem depender de abstrações. Além disso, as abstrações 
/// não devem depender de detalhes, mas sim os detalhes devem depender das abstrações.
/// Abaixo um exemplo de código que segue este princípio:
/// 
/// </summary>

using System.Collections.Generic;

namespace SOLID._05___DependencyInversionPrinciple
{
    public interface IDataProvider
    {
        List<string> GetData();
    }

    public class FileDataProvider : IDataProvider
    {
        public List<string> GetData()
        {
            // ... Código para ler dados de um arquivo ...
            return new List<string>();
        }
    }

    public class DatabaseDataProvider : IDataProvider
    {
        public List<string> GetData()
        {
            // ... Código para ler dados de um banco de dados ...
            return new List<string>();
        }
    }

    public class DataProcessor
    {
        private readonly IDataProvider _dataProvider;

        public DataProcessor(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void ProcessData()
        {
            List<string> data = _dataProvider.GetData();
            // ... Código para processar os dados ...
        }
    }
}

///<summary>
///
/// Neste exemplo, as classes FileDataProvider e DatabaseDataProvider são classes de baixo nível
/// que implementam a interface IDataProvider. A classe DataProcessor é uma classe de alto nível 
/// que depende de uma instância de IDataProvider. 
/// 
/// Ao invés de DataProcessor chamar diretamente a FileDataProvider ou a DatabaseDataProvider, 
/// a classe é criada para depender da interface IDataProvider em vez de uma implementação específica. 
/// Isso significa que outras classes que implementam a interface IDataProvider também podem ser usadas 
/// com o DataProcessor. A técnica de passar dependências como parâmetros é chamada Injeção de Dependência (DI) 
/// e é útil porque torna o código mais flexível e menos acoplado.
/// 
/// </summary>
