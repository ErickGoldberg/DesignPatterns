# Padrões de Projeto (Design Patterns)

Os padrões de projeto (Design Patterns) são soluções reutilizáveis para problemas comuns no desenvolvimento de software. Eles foram popularizados pelo livro "Design Patterns: Elements of Reusable Object-Oriented Software" de Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides, conhecidos como "Gang of Four" (GoF). Existem 23 padrões de projeto descritos no livro, mas aqui vamos focar nos 22 mais conhecidos, divididos em três categorias: Padrões Criacionais, Padrões Estruturais e Padrões Comportamentais.

## Padrões Criacionais

Os padrões criacionais lidam com a criação de objetos, oferecendo maneiras de criar objetos enquanto ocultam a lógica de criação, em vez de instanciar objetos diretamente.

1. **Abstract Factory**
   - Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

2. **Builder**
   - Separa a construção de um objeto complexo da sua representação, permitindo a criação de diferentes representações com o mesmo processo de construção.

3. **Factory Method**
   - Define uma interface para criar um objeto, mas deixa as subclasses decidirem qual classe instanciar. O Factory Method permite que uma classe delegue a responsabilidade da criação às subclasses.

4. **Prototype**
   - Permite a criação de novos objetos a partir de um protótipo existente, clonando-o. Esse padrão é usado quando a criação de instâncias de uma classe envolve custo ou complexidade considerável.

5. **Singleton**
   - Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

## Padrões Estruturais

Os padrões estruturais lidam com a composição de classes e objetos para formar estruturas maiores e mais complexas, mantendo essas estruturas flexíveis e eficientes.

6. **Adapter**
   - Permite que a interface de uma classe existente seja usada como outra interface. É frequentemente usado para fazer classes com interfaces incompatíveis trabalharem juntas.

7. **Bridge**
   - Desacopla uma abstração da sua implementação, permitindo que ambas variem independentemente.

8. **Composite**
   - Compõe objetos em estruturas de árvore para representar hierarquias do tipo todo/parte. Permite que os clientes tratem objetos individuais e composições de objetos de maneira uniforme.

9. **Decorator**
   - Adiciona comportamento ou responsabilidades adicionais a um objeto dinamicamente, sem alterar sua estrutura.

10. **Facade**
    - Fornece uma interface simplificada para um subsistema complexo.

11. **Flyweight**
    - Usa o compartilhamento para permitir a reutilização eficiente de objetos em grande quantidade, evitando a criação de muitas instâncias semelhantes.

12. **Proxy**
    - Fornece um substituto ou placeholder para outro objeto para controlar o acesso a ele.

## Padrões Comportamentais

Os padrões comportamentais se concentram na comunicação entre objetos, facilitando a coordenação e atribuição de responsabilidades.

13. **Chain of Responsibility**
    - Passa pedidos ao longo de uma cadeia de handlers. Ao receber um pedido, cada handler decide se processa o pedido ou se passa para o próximo handler na cadeia.

14. **Command**
    - Encapsula uma solicitação como um objeto, permitindo que os clientes parametrizem objetos com diferentes solicitações, enfileirem ou registrem solicitações e suportem operações que podem ser desfeitas.

15. **Interpreter**
    - Dada uma linguagem, define uma representação para sua gramática junto com um interpretador que usa a representação para interpretar sentenças na linguagem.

16. **Iterator**
    - Fornece um meio de acessar os elementos de um agregado sequencialmente, sem expor sua representação subjacente.

17. **Mediator**
    - Define um objeto que encapsula a forma como um conjunto de objetos interage. O Mediator promove o acoplamento fraco ao impedir que os objetos se refiram uns aos outros explicitamente.

18. **Memento**
    - Sem violar o encapsulamento, captura e externaliza o estado interno de um objeto, permitindo que o objeto seja restaurado para esse estado posteriormente.

19. **Observer**
    - Define uma dependência um-para-muitos entre objetos, de modo que quando um objeto muda de estado, todos os seus dependentes são notificados e atualizados automaticamente.

20. **State**
    - Permite que um objeto altere seu comportamento quando seu estado interno muda. O objeto parecerá ter mudado sua classe.

21. **Strategy**
    - Define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. Permite que o algoritmo varie independentemente dos clientes que o utilizam.

22. **Template Method**
    - Define o esqueleto de um algoritmo na superclasse, permitindo que subclasses sobrescrevam etapas específicas do algoritmo sem modificar sua estrutura.

23. **Visitor**
    - Representa uma operação a ser realizada sobre os elementos de uma estrutura de objeto. Permite que você defina uma nova operação sem mudar as classes dos elementos sobre os quais opera.
