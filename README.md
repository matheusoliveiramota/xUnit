# xUnit
Estudo e exemplos de utilização do Framework de Testes xUnit

## Exemplo de Compartilhamento de Instâncias entre os Testes: _Solution CompartilharObjetos_
- Projeto **SolucaoPerformance1**: Exemplo de compartilhamento de objeto por todos os métodos de teste de *UMA classe*
- Projeto **SolucaoPerformance2**: Exemplo de compartilhamento de objeto por *todas as classes de teste*
- Projeto **TestePerformance**: Teste realizado para identificar o gargalo nos testes realizados ao abrir planilha do excel para buscar dados como massa de teste. Segue imagem do resultado em *Performance Planilha.png*. *Solução*: compartilhar a instância da planilha em todas as classes de teste.
