# Futuregrowth Developer Test

Required assessment by Futuregrowth

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

- MS Sql Express
- Visual Studio 2019 (Community Edition Works)
- Clone this repo

### Installing - Database Backup

- Open MS Sql Server Express. 
- Connect to your instance.
- Right-click "Database" node
- Click "Restore Database"
- Select "Device" radio button
- From the pop-up, click "Add" and browse to the "Database" folder of this cloned repo and select "FuturegrowthDb.bak"

### Installing - Web App

- Open Visual Studio
- Open the solution by browsing to the directory of this cloned repo
- Select "FamilyTree.sln"
- Build the solution, the nuget packages should install

## Running the tests

- The tests are titled "UnitTests" 
- From the Visual Studio menu, click "Test", then "Test Explorer" 
- To run all tests, right-click the first node titled "UnitTests (5)" and click "Run"

### And coding style tests

- The UnitTest project uses xUnit
- The tests follow the behavior driven development approach
- The tests verify the implementation/behavior of the repository functions

## Author

* **Banisa Brown** 
