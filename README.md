# Capitu

**Capitu** é um aplicativo desktop multiplataforma e open source para diagramação automática de textos literários, com exportação para PDF e EPUB. Seu objetivo é oferecer uma alternativa simples, acessível e offline para autores, editoras e educadores criarem obras diagramadas profissionalmente.

## Principais Funcionalidades

- [ ] Importação de textos nos formatos `.txt`, `.md` e `.docx`
- [ ] Detecção automática de estrutura (capítulos, seções, parágrafos)
- [ ] Aplicação de estilos e temas predefinidos
- [ ] Pré-visualização da diagramação
- [ ] Exportação para PDF e EPUB
- [ ] Geração de sumário automático

## Tecnologias Utilizadas

- [.NET 9+](https://dotnet.microsoft.com/)
- [Avalonia UI](https://avaloniaui.net/)
- [QuestPDF](https://www.questpdf.com/)
- [YamlDotNet](https://github.com/aaubry/YamlDotNet)

## Instalação (em desenvolvimento)

```bash
git clone https://github.com/CaioMtho/Capitu.git
cd Capitu
dotnet build
dotnet run --project Capitu.UI
```

## Estrutura

```text
Capitu/
├── Capitu.UI          → Interface gráfica
├── Capitu.Engine      → Lógica da diagramação
├── Capitu.Core        → Modelos e utilitários
└── Capitu.Tests       → Testes unitários e de integração
```
