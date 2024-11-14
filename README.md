# PrimeiroProjeto

Este é um projeto em C# com foco em aprendizado, abordando conceitos básicos de operações matemáticas, entrada de dados do usuário e formatação de saída. A aplicação inclui uma classe base (`CalculoSimples`) com métodos de cálculos variados e uma classe principal (`Program`) que invoca alguns desses métodos.

## Estrutura do Projeto

### Classes e Métodos

1. **Program**
   - Classe principal do projeto que herda de `CalculoSimples` e contém o ponto de entrada da aplicação (`Main`).
   
   - **Métodos principais**:
     - `Main`: Inicializa uma instância de `Program` e chama o método `ExecultarAulaDois()`.
     - `Execultar()`: Realiza várias operações de exibição no console, formatando números e exibindo mensagens. Também faz uso dos métodos herdados de `CalculoSimples`.
     - `ExecultarAulaDois()`: Recebe valores de largura, comprimento e preço por metro quadrado do usuário, calcula a área e o preço total, e exibe os resultados.

2. **CalculoSimples**
   - Classe base que contém métodos auxiliares para cálculos simples.
   
   - **Métodos auxiliares**:
     - `aulaQuatro()`: Método simulado para leitura de números do usuário.
     - `texto()`: Método simulado para leitura de texto do usuário.
     - `numero()`: Método simulado para leitura de números com formatação.
     - `aulaTres()`: Método simulado com cálculos adicionais (detalhes podem ser expandidos).

## Documentação dos Métodos

### Program.Main
Este é o ponto de entrada do programa. Cria uma instância da classe `Program` e executa o método `ExecultarAulaDois()`. 

### Program.Execultar()
Método de exemplo que demonstra:

- **Exibição de valores formatados**: Exibe valores de um número (`double x`) e uma variável de texto (`string z`), com formatações de ponto e vírgula, e mensagens personalizadas.
- **Uso de `CultureInfo.InvariantCulture`**: Utilizado para exibir números com ponto (`.`) ao invés de vírgula.
- **Exemplo de interpolação de strings**: Mostra como combinar variáveis em uma frase com `Console.WriteLine`.

### Program.ExecultarAulaDois()
Realiza um cálculo de área com base em dados inseridos pelo usuário:

1. Solicita a largura, comprimento e o preço por metro quadrado.
2. Calcula a área multiplicando largura e comprimento.
3. Calcula o custo total multiplicando a área pelo preço por metro quadrado.
4. Exibe o resultado formatado no console.

**Exemplo de uso**:
```plaintext
Digite o valor da largura: 10
Digite o valor do comprimento: 20
Digite o valor do metro quadrado: 30
Area do metro quadrado: 200.00
Preço em metros quadrados: 6000.00
