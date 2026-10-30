# Chamados

Sistema de chamados em .NET 10 (Módulos 1 e 2).

## Requisitos
- .NET SDK 10.0.401 (ou superior da mesma faixa 10.0.x, conforme `global.json`)

## Como executar
    dotnet build
    dotnet run --project src/Chamados.Web

## Como testar
    dotnet test

## Decisões
- **.NET 10 LTS como alvo:** é uma versão de suporte de longo prazo (3 anos), com suporte até 14/11/2028.
- **Formato .slnx:** é o formato de solução padrão do SDK 10, baseado em XML, mais simples e legível que o `.sln` antigo.

- **Interface de repositório (Módulo 2):** `ChamadoServico` depende de `IChamadoRepositorio`, e não do dicionário em memória, porque a implementação vai mudar: no Módulo 7 entra o Entity Framework Core com SQLite, sem alterar o serviço nem os testes.
- **TimeProvider injetado (Módulo 2):** o serviço recebe o relógio pelo construtor em vez de usar `DateTimeOffset.UtcNow`. Em produção é `TimeProvider.System`; nos testes, o `RelogioFixo`, que deixa datas e durações previsíveis.
- **Casos de uso no Domain (Módulo 2):** o `ChamadoServico` fica em `Chamados.Domain`, sem uma camada Application separada. Com um único serviço, um projeto a mais seria complexidade sem benefício; a separação será revista quando o domínio crescer.
