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
  
  
  ### GET api/v1/salons/:salonId
  
  #### return salon with the given id
  
  ### POST /api/v1/salons
  body : 
  json 
  {
      "name" : "{name of salon}" ,
      "seatWidth" : {width of each seat (int) } , 
      "seatHeight" : {height of each seat (int) } 
  }

  #### create a new show with the given properties
  
  
  ### GET api/v1/salons/:salonId/seats
  
  #### return lists of all seats in the salon specified with salonId
  
  ### GET api/v1/salons/:salonId/seats/:seatId

  #### return the seat with the given seatId (which should belong to the given salon, otherwise, return BadRequest)
  
  ### POST api/v1/salons/:salonId/seats
  
  json 
    {
        "X" : {position of the seat in x direction (int)}
        "Y" : {position of the seat in y direction (int)} 
    }
    
  #### Add a new seat which belongs to the given salon 
  
```

