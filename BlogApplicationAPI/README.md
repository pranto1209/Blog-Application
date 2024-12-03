# Blog Application


### Update Database

Add-Migration -Context BlogApplicationDbContext BlogApplicationMigration

Add-Migration -Context AuthDbContext AuthMigration

Update-Database -Context BlogApplicationDbContext

Update-Database -Context AuthDbContext


### Login

Email: admin@gmail.com

Password: admin12