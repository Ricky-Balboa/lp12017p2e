# Zombies vs Humans

* André Rosa - a21704022
* Ricardo Leal - a21703090


## Our solution

### Architecture

Para evitar ter o metodo main muito cheio, dividi-mos o código em algumas classes sendo que cada uma contêm vários parâmetros, funções e metodos. 

O ficheiro principal é o "Program.cs". 

![Fluxogram]()

### Data structures

Utilizá-mos **arrays** e **enumerações** em grande parte da estrutura do nosso trabalho, constituem portanto uma parte muito 
importante neste projeto.

Criá-mos ainda uma struct ``AGENT`` que contém a informação se o agente é jogável, a sua ID e o seu tipo.

### Algorithms

**Movimento** 
``switch (tecla)`` Este algoritmo altera uma das coordenadas de um agente controlável. 
Ao clicar **S** é somado 1 ao **y** do agente controlável. 
Ao clicar **A** é subtraído 1 ao **x** do agente controlável. 
Ao clicar **D** é somado 1 ao **x** do agente controlável. 
Ao clicar **W** é subtraído 1 ao **y** do agente controlável. 
O agente vai mover-se então, respectivamente, para **Baixo**, **Esquerda**, **Direita** e **Cima**.

**Limite da grelha**
O nosso jogo dando uso a uma grelha não toroidal utiliza um conjunto de algoritmos que impedem que os agentes ultrapassem os limites do mundo jogável,
sendo estes:

``if (j-1 >= 0)`` Este algoritmo serve para impedir que os agentes ultrapassem o **limite superior** do mundo jogável.
Ou seja, a posição dos agentes nunca pode ser **negativa** em relação a j.                  

``if (i-1 >= 0)`` Este algoritmo serve para impedir que os agentes ultrapassem o **limite esquerdo** do mundo jogável.
Ou seja, a posição dos agentes nunca pode ser **negativa** em relação a i. 

``if (i+1 <= WORLD_X-1)`` Este algoritmo serve para impedir que os agentes ultrapassem o **limite direito** do mundo jogável.
Ou seja, a posição dos agentes nunca pode ser **superior** ao valor de WORLD_X.

``if (j+1 <= WORLD_Y-1)`` Este algoritmo serve para impedir que os agentes ultrapassem o **limite inferior** do mundo jogável.
Ou seja, a posição dos agentes nunca pode ser **superior** ao valor de WORLD_Y. 

## Conclusions

Ao desenvolver este trabalho conseguimos aprofundar, aplicar e perceber melhor os conhecimentos adquiridos em aula. 
O conceito "HumanosVSZombies" é em si muito interessante e agradou-nos bastante. A parte em tivemos mais dificuldades foi em converter ideias e pseudo-código em
código propriamente dito e funcional