# Zombies vs Humans

* André Rosa - a21704022
* Ricardo Leal - a21703090


## Our solution

### Architecture

Tentá-mos dividir o projeto em vários ficheiros, para evitar o excesso de código no método main. O código estava todo funcional e com as tentativas de
dividir o código em vários ficheiros o código parou de funcionar. Como tal, o main está sobrecarregado com excesso de linhas de código. No entanto funciona tudo
na perfeição.

O ficheiro principal é o "Program.cs". 

![Fluxogram](https://cdn.discordapp.com/attachments/369518977745158145/463100254473027595/Fluxograma.png)

### Data structures

Utilizá-mos **arrays**  em grande parte da estrutura do nosso trabalho, constituem portanto uma parte muito 
importante neste projeto.


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
código propriamente dito e funcional. Desenvolve-mos todo o código inicialmente dentro do método main, estando completamente funcional. Tive-mos bastantes 
dificuldades ao dividir o código por vários ficheiros ficheiros, para não sobrecarregar o main. E apesar das nossas tentativas nenhuma delas funcionou.

### Notes

Ao desenvolver este trabalho tivemos sempre lado a lado a trabalhar em conjunto cada linha de código, não sendo possivel dizer o que cada um fez individualmente.
Ao longo do desenvolvimento do projeto tivemos sempre a alterar/trocar pensamentos 
