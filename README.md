# apbd-ef-dbfirst

Potrzebne paczki NuGet:

1. Microsoft.EntityFrameworkCore
2. Microsoft.EntityFrameworkCore.SqlServer
3. Microsoft.EntityFrameworkCore.Tools (działa tylko w VisualStudio)

Komenda do wykonania scaffolda bazy danych:

1. Scaffold-DbContext "Data Source=db-mssql;Initial Catalog=XXXX;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Tables X,Y (VisualStudio)
2. dotnet ef dbcontext scaffold "Data Source=db-mssql;Initial Catalog=XXXX;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer --output-dir Entities --table X --table Y (Rider)
