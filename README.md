# booking



### Developemnt

```bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add Booking.AppDbContext
dotnet ef database update
```



### API
```
  ### GET /api/v1/salons

  #### return list of salons created so far 
  
  ### POST /api/v1/salons
  body : 
  json 
  {
      "name" : "{name of salon}" ,
      "seatWidth" : {width of each seat (int) } , 
      "seatHeight" : {height of each seat (int) } 
  }

  
  #### create a new show with the given properties
```

