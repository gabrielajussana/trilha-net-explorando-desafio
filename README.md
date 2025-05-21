# 🏨 Sistema de Hospedagem em C# - Desafio DIO 

Projeto desenvolvido como parte do Desafio de Projeto da DIO - Trilha .NET (Explorando a linguagem C#). A proposta é simular um sistema de reservas de hotel com regras de negócio específicas e validações importantes.

## Sobre o Desafio
Neste projeto, o objetivo era implementar a lógica de uma aplicação de hospedagem que permitisse:
- Cadastrar hóspedes e suítes;
- Realizar reservas respeitando a capacidade da suíte;
- Calcular o valor total da estadia com aplicação de desconto em casos específicos;
- Retornar a quantidade de hóspedes cadastrados e valor total da hospedagem.

## Requisitos do desafio
As seguintes regras de negócio foram exigidas:
- Não deve ser possível reservar uma suíte com capacidade inferior ao número de hóspedes;
- O método ObterQuantidadeHospedes() deve retornar corretamente a quantidade de hóspedes;
- O método CalcularValorDiaria() deve retornar o valor da diária com desconto de 10% caso a reserva seja para 10 dias ou mais.

## Solução Implementada
- Implementei os métodos marcados com TODO seguindo as regras descritas no enunciado:

### CadastrarHospedes(List<Pessoa> hospedes): 
- Valida se a suíte já foi cadastrada antes de associar os hóspedes.
- Verifica se a quantidade de hóspedes não ultrapassa a capacidade da suíte.
- Lança uma exceção clara caso a regra de capacidade não seja atendida.

###  ObterQuantidadeHospedes()
- Retorna com segurança a quantidade de hóspedes cadastrados, mesmo que a lista seja nula.

### CalcularValorDiaria()
- Calcula o valor total com base nos dias reservados e no valor da diária da suíte.
- Aplica automaticamente um desconto de 10% quando o número de dias reservados for maior ou igual a 10.

## Estrutura de Classes
- Pessoa: Representa um hóspede.
- Suite: Representa uma suíte, com informações como tipo, capacidade e valor da diária.
- Reserva: Relaciona Pessoa e Suite, contendo a lógica de negócios para reserva e cobrança.

## Como executar
- Clone o repositório;
- Abra a solução no Visual Studio ou outro editor C#;
- Execute o projeto para ver os testes e simulações de reserva.