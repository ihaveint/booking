# booking


### Getting Started

This is a .Net Core project that works as a web server on the localhost, It lets you send Http request to the server and receive a proper response.

### Prerequisites

- First, You need to install the .Net Core framework, Here it is a guide for installing [.Net Core SDK](https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1904) on different OS's.

- Second, It's time to install needed dependencies like 
    - Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Relational
	- Microsoft.EntityFrameworkCore.Design
	
So to add these packages to the project we use the below command:
```
dotnet add package <package_name>
```
Note:  if the project needs any other dependency in the future you can add them the same way.

### Installing

- After you clone the project into your local system, you need to handle migrations part, don't worry if you have no knowledge about migrations(It's a part of EntityFrameworkCore), you need only to execute these commands only:
```
dotnet tool install --global dotnet-ef
dotnet ef migrations add Booking.AppDbContext
dotnet ef database update
```
- Now you can run the project:
```
dotnet run
```

## How To Use

## Project functionalities:
- #### 1. get lists of all created salons so far from server
- #### 2. get properties of a specific salon from server
- #### 3. create a new salon
- #### 4. get list of all seats of a specific salon
- #### 5. get properties of a specific seat from server
- #### 6. create a new seat

### 1 : getting all salons
For this purpose you need to send a get request to server and receive a json (representing all salons) from the server
```
curl -i localhost:5000/api/v1/salons/
```

### 2 : getting a specific salon 
for this purpose you need to send a get request to server and receive a json (representing a single salon) from the server 
```
curl -i localhost:5000/api/v1/salons/:salonId
```

### 3 : creating a new salon
For this purpose you need to send a post request to server and receive a json (representing properties of created salon) 
(in json format , containing key/values for "name" -> salonName , "seatWidth" -> width of each seat in salon ,
 "seatHeight" -> height of each seat in salon)
```
curl -i -d '{"name" : "name of salon" , "seatWidth" : integer , "seatHeight" : integer }' -H "Content-Type: application/json" -X POST http://localhost:5000/api/v1/salons
```

### 4 : getting all seats of a specific salon
For this purpose you need to send a get request to server and receive a json (representing properties of all seats of given salon)
```
curl -i localhost:5000/api/v1/salons/:salonId/seats/
```

### 5 : getting a specific seat
For this purpose you need to send a get request to server and receive a json (representing a single seat of given salon)
```
curl -i localhost:5000/api/v1/salons/:salonId/seats/:seatId
```

### 6 : creating a new seat
For this purpose you need to send a post request to server and receive a json (representing properties of created seat) 
(in json format , containing key/values for "X" -> x position of seat in integer , "Y" -> y position of seat in integer)
```
curl -i -d '{"X" : integer , "Y" : integer }' -H "Content-Type: application/json" -X POST http://localhost:5000/api/v1/salons/:salonId/seats
```

## Built With 

* [Dotnet](https://dotnet.microsoft.com/) - The web framework used
* [PostgreSQL](https://www.postgresql.org/) - Database Management