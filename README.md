Nelio Alves - C# primeiros passos: Lógica de Programação e Algoritmos

Link: https://www.udemy.com/course/logica-de-programacao-csharp/

**ALGORITMO**
-Sequência finita de instruções para se resolver um problema.

**AUTOMAÇÃO**
- Consiste em utilizar maquinas para executar o procedimento desejado de forma automática ou semiautomática.

**O QUE É NECEESSÁRIO PARA FAZER UM PROGRAMA DE COMPUTADOR**
- Uma linguagem de programação: regras léxicas(ortografia) e sintáticas(Gramatica) para se escrever o programa.
- Uma IDE: Software para editar e testar o programa
- Um compilador: Software para transformar o código fonte em código objeto
- Um gerador de código ou máquina virtual: Software que permite que o programa seja executado.

**LINGUAGEM DE PROGRAMAÇÃO LÉXICA, SINTÁTICA**
- Léxica, diz respeito a correção das palavras ‘Isoladas’ (ortografia).
- Sintática diz repeito a correção das sentenças (gramática).

**IDE - AMBIENTE INTEGRADO DE DESENVOLVIMENTO**
- É um conjunto de softwares utilziados para construção de um software.
- C/C++: Code Blocks
- Java: Eclipse, NetBeans
- C#: Visual Studio

**FUNCIONALIDADES DA IDE**
- Edição de código fonte (Edentação, autocompletar, destaque de palavras)
- Depuração e testes
- Construção do produto final (build)
- Sugestão de modelos (templates)
- Auxiliar em várias tarefas do seu projeto.
- Etc….

**COMPILAÇÃO E INTERPRETAÇÃO CÓDIGO FONTE E OBJETO MÁQUINA VIRTUAL**
- Código fonte: É o escrito pelo programador em linguagem de programação.
- Compilação em C, C++: Codigo fonte → Compilador: Compilação (Analise léxica + Sintática) → Código objeto → Gerador de código construção (build) → Codigo Executável → Execução
- Compilação interpretação em PHP, JavaScript, Python, Ruby: Código fonte → Interpretador: interpretação (Analise léxica, sintática, geração ed código, Sob demanada) → Execução
- Compilação hibrida Java (JVM), C# : Código fonte → Compilador: precompilação (Analise lexica, sintática) → Bytecode → Maquina virtual:Interpretação(geração de código sob demanda).
      
    **VANTAGENS**
    - Compilação: Velocidade do programa, auxilio do compilador antes da execução
    - Interpretação: Flexibilidade dae manutenção do aplicativo em produção, expressividade da linguagem, código fonte não precisa ser recompilado para rodar em plataforma diferente.
    - Abordagem hibrida: código fonte não precisa ser recompilado para rodar em plataforma diferente, auxilio do compilador antes da execução e as demais de compilação e interpretação.

# 2 - ESTRUTURA SEQUÊNCIAL
**Operadores aritméticos**
+ adição
- subtração
* multiplicação
/ divisão
% resto da divisão ("mod")

Precedência: 1º lugar: * / % 2º lugar: + -

**Variáveis tipos básicos em C#**
- Um programa de computador em execução lida com dados, esses dados são armazenados em VARIAVÉIS.
- Variavel é uma porção de memória RAM utilizada para armazenar dados durante a execução dos programas.

**Declaração de Variaveis**
SINTAXE: <TIPO> <NOME> = <VALOR INICIAL (OPCIONAL)>;

**Como nomear as variaveis**
- Não pode começar com digito: use uma letra ou _
- Não pode ter espaço em branco
- Não usar acentou ou til
- Sugestão: Use o padrão “Camel Case”

***Um programa de computador é capaz de realizar essencialmente três operações**
ENTRADA DE DADOS: Quando o usuário informa os dados para o programa através do teclado.
PROCESSAMENTO DE DADOS: É quando o programa realiza os cálculos através do comando de atribuição.
SAÍDA DE DADOS: O programa informa os dados para o usuário através do monitor.

**Funções Matemáticas**
- Algumas funções matemáticas em C#;
    - A = MATH.SQRT(X) - Variável A recebe a raiz quadrada de X
    - A = MATH.POW(X, Y ) - Variável A recebe o resultado de X elevado  Y.
        - A = MATH.ABS(X) - Variavel A recebe o valor absoluto(número sem sinal) de X.

# Estrutura Condicional 
**Expressão Comparativa:**
    > Maior
    < Menor
    >= Maior ou Igual
    <= Menor ou Igual
    == Igual
    != Diferente

**Estrutura Condicional** - É uma estrutura de controle que permite definir que um certo bloco de comandos somente será executado dependendo de uma condição.

# Estrutura Repetitivas
**While** - É uma estrutura de controle que repete um bloco de comandos enquanto uma condição for verdadeira. 
    Quando usar: Quando não se sabe previamente a quantidade de repetiçõs que será realizada.
    Regra: Verdadeira: Executa e volta - Falso: Pula Fora
    While(Condição) { }

**For** - É uma estrutura de controle que repete um bloco de comandos para um certo intervalo de valores.
    Quando usar: Quando se sabe previamente a quantidade de repetições, ou o intervalo de valores.
    For(inicio ; condição; incremento) { } 

**Do While** - É menos utilziada, mas em alguns casos se encaixa melhor ao problema, o bloco de comandos  executa pelo menos uma vez, pois a condição é verificada no final.
    Regra: Verdadeira: volta Falso: Pula fora
    Do { 
    } while (Condição)

# Vetores
- Vetores são também chamados de arranjos unidimensionais.
- Em C# a primeira posição do vetor é a 0.
- Um arranjo deve ser alocado previamente antes de ser utilizado, Uma vez alocado sua quantidade de elementos é fixa.
    - Um vetor corresponde a uma coleção de dados de tamanho fixo, indexada, unidimensional e homogênea.
    - Indexada - Os elementos são acessos por meio de indices.
    - Unidimensional: Uma dimensal
    - Homogêna: Todos os dados são do mesmo tipo
    
**Como criar um vetor:**    
    DECLARAÇÃO: Cria as variavéis na memória mas ainda sem espaço
    int[ ] A;
    double[] B;
    string[] C;
    
**INSTANCIAÇÃO:** Alocação do vetor na memoria RAM.
    A = new int[10];
    B = new double[5];
    C = new string[8];
    
**Foreach** - é usado quando precisa percorrer todos os elementos de uma coleção. Para cada elemento dentro do vetor o mesmo será passado para o X.
    foreach (string x in vetor) 
    {
        console.writeline(x)
    }

# Matrizes
- Uma matriz corresponde a uma coleção de dados de tamanho fixo, indexada, bidimensional e homogênea.
    - indexada: os elementos são acessados por meio de índices.
    - Bidimensional: Duas dimensões
    - Homogênea: Todos dados são do mesmo tipo

- Matrizes são chamadas de arranjos bidimensionais, em c# a primeira posição de uma matrz é a posição 0, 0 (Linha 0, Coluna 0).
- Um arranjo deve ser alocado previamente, antes de ser utilizado, uma vez alocado, sua quantidade de elementos é fixa.

**Como criar Matriz?**
Declaração: 
double[ , ] A;

A = new double [3,4] ira criar uma matriz de 3 linhas e 4 colunas;
