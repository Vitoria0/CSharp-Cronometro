# Cronômetro Console

Este é um simples cronômetro de console em C# que permite ao usuário iniciar um cronômetro e visualizar o tempo decorrido. O cronômetro é executado no console e pode ser interrompido a qualquer momento.

## Funcionalidades

- **Iniciar Cronômetro**: Inicia um cronômetro e exibe o tempo decorrido no formato `HH:mm:ss.SSS`.
- **Sair**: Encerra o programa.

## Como Usar

1. Clone o repositório para sua máquina local.
2. Compile o projeto usando o .NET SDK:
    ```bash
    dotnet build
    ```
3. Execute o programa:
    ```bash
    dotnet run
    ```
4. No menu exibido, escolha uma das opções:
   - **1**: Iniciar o cronômetro.
   - **2**: Sair do programa.

## Código

O código-fonte principal está localizado na classe `Program` no arquivo `Program.cs`. A seguir estão os métodos principais:

- **Menu**: Exibe o menu principal e lida com a escolha do usuário.
- **Start**: Inicia o cronômetro e exibe o tempo decorrido até que uma tecla seja pressionada.

## Exemplo

Ao iniciar o programa, o menu será exibido. Ao escolher a opção para iniciar o cronômetro, você verá o tempo decorrido sendo atualizado no console até que você pressione uma tecla para parar o cronômetro e retornar ao menu.

## Requisitos

- .NET SDK 5.0 ou superior

## Contribuições

Se você deseja contribuir para este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request. Toda contribuição é bem-vinda!

## Licença

Este projeto é licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
