# Blog Application

### Add Migrations

dotnet ef migrations add BlogApplicationMigration --context BlogApplicationDbContext

dotnet ef migrations add AuthMigration --context AuthDbContext

or

Add-Migration -Context BlogApplicationDbContext BlogApplicationMigration

Add-Migration -Context AuthDbContext AuthMigration

### Update Database

dotnet ef database update --context BlogApplicationDbContext

dotnet ef database update --context AuthDbContext

or

Update-Database -Context BlogApplicationDbContext

Update-Database -Context AuthDbContext


