# Introduction 
Proyecto desarrollado en el entrenamiento:<br>
**Blazor WebAssembly (.NET 7) con Clean Architecture** <br>
<https://ticapacitacion.com/curso/wasm7/>.<br>

``` mermaid

graph TD
  A[Christmas] —>|Get money| B(Go shopping)
  B --> C{Let me think)
  B --> G[/Another/]
  C ==>|One| D[Laptop]
  C -->|Two| E[iPhone]
  C -->|Three| F[fa:fa-car Car]
  subgraph section
    A
    B
    C
    D
  end
```
