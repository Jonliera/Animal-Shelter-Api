# Animal Shelter API

####  An ASP.NET Core REST API that allows the user to keep track of the Animals in a shelter. 
 
-------------------------

## Authored By:
Jonathan Liera February 2023

-------------------------
## Table of Contents
1. [Description](#Description)
2. [Technologies Used](#technologies-used)
3. [Setup Instructions](#installation-and-setup)
4. [API Documentation](#api-documentation)
5. [Known Bugs](#known-bugs)
6. [License Information](#License)

-------------------------

## About the project

### Description

####  An api that allows the user to keep track of all the animals that are kept in a shelter. This API utilizes RESTFul principles and version control.The user must use POSTMAN to look at two different version of the project.  

-------------------------
## Technologies Used

* _C#_
* _Entity Framework Core_
* _Net 6.0 SDK_
* _MySQL Server
* _MySQL WorkBench
* _Visual Studio Code_
* _Github_
* _Razor_
* _Markdown_
 
 -------------------------

## Setup/Installation Requirements

1. To begin, install .Net 6 SDK and follow the directions to have access to C# and its editor. 
2. Clone this repository to your desktop.
3. Navigate to the AnimalShelterApi.Solution  main directory on your computer.
4. Once in the  AnimalShelterApi production file, run `$ dotnet restore` to install packages to be able to run this repository.
5. Add the following files to your .gitignore file:
  `obj/`
  `bin/`
  `appsettings.json`
  `appsettings.*.json`
6. Initialize the project, add .gitignore and commit your changes.

#### Setting Up the Databse
7. Within the AnimalShelterApi.Solution/AnimalShelterApi folder, create a file titled `appsettings.json`
8. In the appsettings.json file paste the following code:
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animalshelter_api;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

### Create a local schema
1. Navigate to the root directory of the project
2. Enter `$ dotnet ef migrations add Initial` to create your first database migration with seeded data
3. Enter `$ dotnet ef database update` to push migration information to your MySql workbench

### Execute the Program

1. Open your terminal and navigate to the production directory.
2. Run `dotnet run` in the command line to run the program.

#### Access the API
1. For this project we recommend you use Postman to view your API. However you can also use Swagger.

### Endpoints

Base URL : `http://localhost:5218` or `http://localhost:7160`
<br>

#### HTTP Request Structure

_Available in Version 1 and Version 2_


```GET/api/v{version}/animals```
```POST/api/v{version}/animals```
```PUT/api/v{version}/animals/{id}```
```DELETE/api/v{version/animals/{id}```


#### Paramaters

| Name | Type   | Description |
| ---- | ----   | ----------- |
| name | string | Filters Animals by name |
| type | string | Filters Animals by type |
| age  | int    | Filters Animals by age  |
| friendly | boolean | Filters Animals by whether they are friendly or not |
| sex  | string | Filters Animals by sex |


## Known Bugs

* _No known bugs_

## License

_If you have any questions or concerns please contact me @jonliera1@gmail.com. You are also welcome to contribute if you feel you may so.

*_MIT License_

Copyright <Nov 2022> <Jonathan Liera>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
