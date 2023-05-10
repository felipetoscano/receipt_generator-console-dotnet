# Gerador de recibos
Projeto em C# que gera recibos, utilizando os Design Patterns "Builder", "Fluent Interface" e "Observer".

Neste exemplo, precisamos gerar um objeto de recibo e simplesmente exibir na tela. Este objeto é relativamente grande e complexo para ser criado, pelo número de campos, por algumas lógicas que estão presentes dentro do recibo, como calculo de valor total e impostos e a lista de itens dentro dele.

Ao tentar gerá-lo na classe "Program", onde estamos realizando os testes, é possível perceber que exige um certo nível de complexidade e também deixa o código um pouco confuso na sua leitura.

Para resolver isso, criamos a classe "ReceiptBuilder", que tem a responsabilidade de implementar as lógicas para a instanciação de "Receipt". Cada um dos métodos é escrito de forma para simplificar a leitura e visualização do código. Esta classe utiliza dos mesmos princípios da classe "StringBuilder", presente na lib nativa "System.Text", que em seu caso, auxilia o usuário a criar um texto. Este padrão é chamado de "Builder".

Na mesma classe "ReceiptBuilder", também implementamos outro padrão chamado "Fluent Interface", que é basicamente a implementação de um método chamando outro da mesma classe. Isso reduz a quantidade de vezes em que referenciamos a variável "receiptBuilder.metodo()" e também torna o código muito mais legível.

A classe "ReceiptBuilder" é responsável apenas por **AUXILIAR** na criação das classes, **e não ter regras de negócio para execução de ações**. Por isto, foi criada uma classe para cada uma das ações, que herdam da interface "IAction". Desta forma, quem utiliza a classe builder será responsável por enviar uma lista de ações, seja lá quantas ou a ordem delas, que a classe Builder irá executar cada uma delas sem praticamente nenhum acoplamento.

Desta maneira, iremos notificar a classe "ReceiptBuilder" com uma lista de ações a serem executadas, por isto o nome "Observer".

O Observer é utilizado para diminuir o acoplamento das classes, quando precisamos executar uma série de ações, por exemplo.


