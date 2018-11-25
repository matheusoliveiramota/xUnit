using SolucaoPerformance1.Shared;
using Xunit;

namespace SolucaoPerformance2.Test.Shared
{
    [CollectionDefinition("Pessoa collection")]
    public class SharedCollection : ICollectionFixture<BeforeAllTestClasses>
    {
        // Classe sem implementação
            // Existe apenas para centralizar a Collection que irá referenciar o objeto compartilhado
                // Classe: BeforeAllTestClasses
    }
}
