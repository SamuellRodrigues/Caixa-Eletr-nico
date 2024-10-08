## CAIXA ELETRÔNICO
## O que foi utilizado

Este projeto foi desenvolvido em **C#**, utilizando as seguintes ferramentas e conceitos:

- **.NET SDK**: Para compilar e executar o projeto.
- **Classes e Objetos**: Uso da classe `Usuario` para gerenciar os dados de cada usuário do sistema.
- **Estruturas de controle (if, switch, loops)**: Para permitir diferentes operações no caixa eletrônico.
- **Listas**: Armazenamento dos múltiplos usuários em uma lista.
- **Autenticação de usuário**: Implementada com uma combinação de nome de usuário e senha de 6 dígitos.
- **Controle de fluxo com transações financeiras**: Respeitando limites de saldo e limites de transação diária.
  
## Etapas implementadas

1. **Criação da estrutura de usuário**:
   - Implementação da classe `Usuario` para representar os dados de cada usuário (nome, senha, saldo, tipo de conta e limite de saque).
   
2. **Autenticação**:
   - Validação de nome de usuário e senha. Se a combinação estiver incorreta, o usuário é solicitado a tentar novamente.

3. **Operações bancárias**:
   - **Depósito**: Possibilidade de adicionar dinheiro ao saldo do usuário.
   - **Saque**: Respeitando o limite de saque diário e o saldo disponível.
   - **Extrato**: Visualização do saldo atual.
   - **Transferência**: Transferência entre contas com a aplicação de uma taxa de 0,05%.
   - **Aplicação financeira**: Permite aplicar o saldo em Poupança ou CDB, com rendimentos mensais simulados.

4. **Limites de transações diárias**:
   - Implementado controle de limite diário de R$10.000 para operações bancárias (depósito, saque e transferência).

5. **Multiplos usuários**:
   - Inclusão de suporte a múltiplos usuários com diferentes contas (corrente e poupança), e cada um com suas operações e saldo individual.

## Conclusão

Este projeto simula um caixa eletrônico básico com funcionalidades essenciais, como depósito, saque, transferência, extrato e aplicação financeira, além de permitir a autenticação de usuários. Foi implementada uma estrutura simples para gerenciar múltiplos usuários, validando suas senhas e diferenciando os tipos de contas. O projeto pode ser expandido com novas funcionalidades, como relatórios de transações ou integração com um banco de dados.

Ele demonstra conceitos fundamentais de programação, como manipulação de objetos, controle de fluxo, listas e lógica de negócios aplicada ao mundo real, como controle de saldo e taxas de transação. É uma base sólida para projetos mais complexos no domínio bancário ou de sistemas financeiros.

