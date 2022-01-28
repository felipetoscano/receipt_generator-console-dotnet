# receipt-generator
Projeto em C# que gera recibos, utilizando os Design Patterns "Builder", "Fluent Interface" e "Observer".

Neste exemplo, além dos padrões "Builder" e "Fluent Interface", implementamos o padrão "Observer".

O Observer é utilizado para diminuir o acoplamento das classes, quando precisamos executar uma série de ações, por exemplo.

A classe "ReceiptBuilder" é responsável apenas por auxiliar na criação das classes, e não ter mais regras de negócio para execução de ações. Por isto, foi criada uma classe para cada uma das ações, que herdam da interface "IAction". Desta forma, quem utiliza a classe builder será responsável por enviar uma lista de ações, seja lá quantas ou a ordem delas, que a classe Builder irá executar cada uma delas sem praticamente nenhum acoplamento.

