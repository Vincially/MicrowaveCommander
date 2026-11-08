# MicrowaveCommander

Exercício técnico: simulador de micro-ondas feito em .NET 10. O front é Blazor WebAssembly e conversa com uma API ASP.NET Core que guarda programas de aquecimento em SQL Server.

## O que faz
- Aquecimento manual: informo minutos, segundos e potência (0 a 10) e o timer regressivo roda na tela. Máximo de 2 minutos e mínimo de 1 segundo.
- Início rápido: com os campos vazios, aquece 30 segundos na potência 10. Apertar de novo com o timer rodando soma 30 segundos.
- Pausar, parar e resetar.
- Programas prontos: Pipoca, Leite, Carnes de boi, Frango e Feijão. Cada um tem tempo, potência e um caractere próprio que aparece repetido a cada segundo, na quantidade da potência.
- A API expõe `GET /api/programs`, que lista os programas gravados no banco.

## Estrutura
- `MicrowaveCommander.API`: controllers, DTOs e validators (FluentValidation).
- `MicrowaveCommander.Domain`: entidade e interface do repositório.
- `MicrowaveCommander.Infrastructure`: EF Core, repositório e migrations.
- `MicrowaveCommander.Front`: Blazor WebAssembly com Bootstrap.

## Como rodar
Precisa do SDK do .NET 10 e de um SQL Server em `localhost,1433`.

A senha do banco não está no repositório. Em `appsettings.Development.json`, troque `SUA_SENHA_AQUI` pela senha do seu SQL Server local (sem commitar essa mudança), ou defina a variável de ambiente `ConnectionStrings__DefaultConnection`.

A partir da pasta `src/MicrowaveCommander`:
```
dotnet ef database update --project MicrowaveCommander.Infrastructure --startup-project MicrowaveCommander.API
dotnet run --project MicrowaveCommander.API
dotnet run --project MicrowaveCommander.Front
```

## Status
Em andamento. A criação de programa personalizado está só começada: existe o validator e a entidade aceita `IsCustom`, mas a página `CreateCustomProgram` está vazia e o repositório ainda não grava programas. A tela de aquecimento ainda usa os presets escritos no próprio código.
