<h1 align="center">
   API .NET 8 - Ficha Academia
</h1>

</br>
  
<p align="center">
  <a href="#white_check_mark-Features">Features</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#globe_with_meridians-Technologies-and-Concepts-Implemented">Technology</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
   <a href="#gear-Architecture">Architecture</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
   <a href="#gear-Architecture">Endpoints</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#wrench-How-to-use">How to use</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-Licence">Licence</a>
</p>


## :white_check_mark: Features

* WebAPI was built with .NET 8
* CRUD using ORM Entity Framework Core
* AutoMapper

## :globe_with_meridians: Technologies and Concepts Implemented

This project was developed using:

- .NET 8
- Entity Framework Core 8.0.4
- AutoMapper 12.0.0
- Swagger 6.4.0

Concepts/Techniques used in:
- Data Transfer Object [DTO]
- Repository Pattern
- Dependency Injection

## :gear: Architecture

```🌐
src
├── 📂 1- API
|   ├── 📂 Controllers
├── 📂 2- Business
|   ├── 📂 Contract
├── 📂 3- Models
|   ├── 📂 DTO
|   ├── 📂 Model
├── 📂 4- Repository
|   ├── 📂 Contract
├── 📂 5- Commom
|   ├── 📂 Commom
|       ├── 📂 Helper
|       ├── 📂 Utils
|   ├── 📂 CrossCutting
|       ├── 📂 DependencyGroups
|       ├── 📂 MappingGroups
├── 📂 5- Migrations
|   ├── 📂 Configurations
|   ├── 📂 Context
|   ├── 📂 Migrations

```

## :round_pushpin: Endpoints
![screenshot-localhost_5086-2024 06 17-08_59_05](https://github.com/heberGustavo/api-ficha-academia/assets/44476616/5514ce54-36ec-482e-919e-89b2aa9f855a)


## :wrench: How to use

Clone that application using [Git](https://git-scm.com) and follow the next steps:

```bash
# 1. Clone this repository
$ git clone https://github.com/heberGustavo/api-ficha-academia.git

# 2. Open the project in Visual Studio

# 3. Execute the build

# 4. Change the Connection String. To modify follow this path:
  4.1 - API > ApiFichaAcademia > appsettings.json
  4.2 - Modify the value to "FichaAcademiaConnection"

# 5. Execute Migration
  5.1 - Open the "Package Manager Console"
  5.2 - Select the project "Migration" in "Default project"
  5.3 - Execute this commands: Update-Database

# 6. Run the application

```

## :memo: Licence 
This project is under the MIT license. See the [LICENSE] for more information.


## Autor

| [<img src="https://avatars.githubusercontent.com/u/44476616?v=4" style="max-width: 100%;width: 90px;"><br><sub>Heber Gustavo</sub>](https://github.com/heberGustavo) |
| :---: |
|[Linkedin](https://www.linkedin.com/in/heber-gustavo/)|
