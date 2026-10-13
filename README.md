# Chamados

Sistema de chamados em .NET 10 (Módulo 1).

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
