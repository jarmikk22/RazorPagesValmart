##Overview
This application provides stock system which user can get, add, update and delete product information.

### Database
Using sql server being able to run by using microsoft docker image and command below:
```
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Password@1234" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server:2019-latest
```

###Reference
- Razor Pages web app: https://docs.microsoft.com/th-th/aspnet/core/tutorials/razor-pages/?view=aspnetcore-5.0
