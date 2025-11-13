# 📅 Cadastro de Eventos - .NET MAUI

Projeto completo de cadastro de eventos desenvolvido em .NET MAUI, com cálculo de duração e custo total.

## 🎯 Funcionalidades Implementadas

### ✅ Requisitos Atendidos

1. **BindingContext**: Todos os dados são vinculados à model `Evento` usando data binding bidirecional
2. **Navegação**: Após cadastro, os dados são apresentados em uma página de resumo formatada
3. **Validações**: Implementadas validações para todos os campos obrigatórios

## 📁 Estrutura do Projeto

```
CadastroEventosApp/
├── Models/
│   └── Evento.cs                    # Model com propriedades e cálculos
├── Views/
│   ├── CadastroEventoPage.xaml      # Tela de cadastro
│   ├── CadastroEventoPage.xaml.cs   # Lógica do cadastro
│   ├── ResumoEventoPage.xaml        # Tela de resumo
│   └── ResumoEventoPage.xaml.cs     # Lógica do resumo
├── App.xaml / App.xaml.cs           # Configuração da aplicação
├── AppShell.xaml / AppShell.xaml.cs # Shell de navegação
├── MauiProgram.cs                   # Configuração do MAUI
└── CadastroEventosApp.csproj        # Arquivo do projeto
```

## 🔧 Como Configurar

### Pré-requisitos
- Visual Studio 2022 (17.8 ou superior)
- Workload ".NET Multi-platform App UI development" instalado
- .NET 8.0 SDK

### Passos para Executar

1. **Criar o Projeto**:
   - Abra o Visual Studio 2022 ou VS Code
   - Crie um novo projeto ".NET MAUI App"
   - Nome: `CadastroEventosApp` (importante usar este nome exato)

2. **Estruturar as Pastas**:
   ```
   - Criar pasta "Models"
   - Criar pasta "Views"
   ```

3. **Adicionar os Arquivos**:
   - Copie todos os arquivos fornecidos para as respectivas pastas
   - Substitua os arquivos padrão (App.xaml, AppShell.xaml, etc.)

4. **Compilar e Executar**:
   - Selecione a plataforma desejada (Android, iOS, Windows, MacCatalyst)
   - Pressione F5 para executar

## 💡 Detalhes Técnicos

### Model - Evento.cs

A classe `Evento` implementa:
- **Propriedades básicas**: Nome, datas, participantes, local, custo
- **Propriedades calculadas**:
  ```csharp
  public int DuracaoEmDias
  {
      get
      {
          TimeSpan duracao = DataTermino - DataInicio;
          return duracao.Days + 1; // +1 para incluir o dia inicial
      }
  }

  public decimal CustoTotal
  {
      get => NumeroParticipantes * CustoPorParticipante * DuracaoEmDias;
  }
  ```

### Data Binding

Exemplo de binding bidirecional:
```xml
<Entry Text="{Binding Nome}" />
<DatePicker Date="{Binding DataInicio}" />
```

### Cálculo com DateTime e TimeSpan

```csharp
// Calcula a diferença entre datas
TimeSpan duracao = DataTermino - DataInicio;

// Obtém os dias de duração
int dias = duracao.Days + 1;
```

## 🎨 Interface do Usuário

### Tela de Cadastro
- Campos para entrada de dados
- Validação antes de prosseguir

### Tela de Resumo
- Card destacado com informações do evento
- Card financeiro com custo total em destaque
- Formatação de valores monetários (R$ 0,00)
- Formatação de datas (dd/MM/yyyy)
- Ícones para melhor visualização

**Desenvolvido como projeto educacional para demonstração de conceitos do .NET MAUI** 
