TransferBank 🏦

Este é um projeto de simulação de operações bancárias desenvolvido em C# como parte do curso prático da Digital Innovation One (DIO), ministrado pelo **Eliézer Zarpelão**.

📋 Sobre o Projeto

O TransferBank é uma aplicação console que simula um sistema bancário básico, permitindo realizar operações financeiras comuns como transferências, saques e depósitos. O sistema suporta dois tipos de contas: Pessoa Física e Pessoa Jurídica.

🚀 Funcionalidades

- Listagem de contas cadastradas
- Criação de novas contas
- Transferências entre contas
- Operações de saque
- Operações de depósito
- Sistema de crédito por conta
- Validação de saldo e limites

🛠️ Tecnologias Utilizadas

- C# (.NET)
- Programação Orientada a Objetos
- Listas e Coleções
- Enums
- Métodos e Classes

## 📦 Estrutura do Projeto

O projeto está organizado em três principais arquivos:

1. `Program.cs`: Contém a lógica principal do programa e o menu de interação
2. `Conta.cs`: Implementa a classe Conta com suas propriedades e métodos
3. `TipoConta.cs`: Define o enum com os tipos de conta disponíveis

💻 Como Usar

1. Clone o repositório
2. Abra o projeto em sua IDE preferida (Visual Studio, VS Code, etc.)
3. Execute o programa
4. Use o menu interativo para:
   - Listar contas (opção 1)
   - Inserir nova conta (opção 2)
   - Realizar transferências (opção 3)
   - Efetuar saques (opção 4)
   - Fazer depósitos (opção 5)
   - Limpar a tela (opção C)
   - Sair do programa (opção X)

⚙️ Funcionalidades Detalhadas

Criação de Conta
- Suporte para Pessoa Física e Jurídica
- Definição de saldo inicial
- Estabelecimento de limite de crédito

Operações Financeiras
- **Saque**: Validação de saldo e limite de crédito
- **Depósito**: Atualização automática de saldo
- **Transferência**: Verificação de disponibilidade e execução segura

🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para:
- Reportar bugs
- Sugerir novas funcionalidades
- Melhorar a documentação
- Enviar pull requests

✨ Agradecimentos

Agradecimento especial à Digital Innovation One (DIO) e ao instrutor Eliézer Zarpelão pelo excelente conteúdo e orientação no desenvolvimento deste projeto.

📝 Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
