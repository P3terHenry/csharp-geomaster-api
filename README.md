<a id="readme-top"></a>

# 📐 Checkpoint CP4 - API de Cálculos Geométricos (C# + ASP.NET Core)

![Static Badge](https://img.shields.io/badge/build-passing-brightgreen) 
![Static Badge](https://img.shields.io/badge/Version-1.0.0-black) 
![License](https://img.shields.io/badge/license-MIT-lightgrey)

## 🧑‍🤝‍🧑 Informações do Contribuinte

| Nome | Matrícula | Turma |
| :-----------------------------: | :------------: | :------: |
| Pedro Henrique Vasco Antonieti | 556253 | 2TDSPH |

<p align="right"><a href="#readme-top">Voltar ao topo</a></p>

---

## 🚩 Características

API RESTful desenvolvida em **C# com ASP.NET Core**, aplicando princípios do **SOLID** e boas práticas de Clean Code.  
O objetivo é disponibilizar endpoints para cálculos geométricos em 2D e 3D, como **área, perímetro, volume e área superficial**, além de um desafio extra de **validação geométrica entre formas**.

<p align="right"><a href="#readme-top">Voltar ao topo</a></p>

---

## 🛠️ Tecnologias Utilizadas

![Static Badge](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Static Badge](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) 
![Static badge](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)
![Static Badge](https://img.shields.io/badge/REST_API-FF6F00?style=for-the-badge&logo=api&logoColor=white)

<p align="right"><a href="#readme-top">Voltar ao topo</a></p>

---

## 📂 Estrutura do Projeto

- **Interfaces**: `ICalculos2D`, `ICalculos3D`, `ICalculadoraService`.
- **Models**: Implementações das formas (`Circulo`, `Retangulo`, `Esfera`).
- **Services**: `CalculadoraService` para orquestração dos cálculos. 
- **Controllers**: `CalculosController`
- **DTOs**: `FormaRequest`, `ErrorResponse`.  
- **Validators**: Validações de entrada (ex: valores negativos não permitidos).

<p align="right"><a href="#readme-top">Voltar ao topo</a></p>

---

## 📌 Endpoints Principais

### Cálculos 2D
- `POST /api/v1/calculos/area`
- `POST /api/v1/calculos/perimetro`

### Cálculos 3D
- `POST /api/v1/calculos/volume`
- `POST /api/v1/calculos/superficie`

### Validações Extras
- `POST /api/v1/validacoes/forma-contida` → Verifica se uma forma está geometricamente contida dentro de outra (ex: círculo dentro de retângulo).
- OBS: Esse eu não realizei, devido a limitações de tempo e complexidade adicional.

<p align="right"><a href="#readme-top">Voltar ao topo</a></p>

---

## 💻 Inicializar Projeto

### 📝 Pré-requisitos
- **.NET 8.0 SDK** ou superior → [Download .NET](https://dotnet.microsoft.com/download)  
- **Visual Studio 2022** ou **Visual Studio Code**

---

### 🗃️ Instalação e Execução

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/CheckpointCP4.git
   ```
2. Entre na pasta do projeto:
   ```sh
   cd CheckpointCP4
   ```
3. Restaure as dependências:
   ```sh
   dotnet restore
   ```
4. Execute a aplicação:
   ```sh
   dotnet run
   ```
