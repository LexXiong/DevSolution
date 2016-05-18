using System;
using System.Collections.Generic;
using System.Data;
using Boying.Data.Migration;

namespace Boying.Users
{
    public class UserDataMigrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("UserRecord",
              table => table
                  .ContentRecord()
                  .Column<string>("Mobile")
                  .Column<string>("UserName")
                  .Column<string>("NormalizedUserName")
                  .Column<string>("Password")
                  .Column<string>("PasswordFormat")
                  .Column<string>("HashAlgorithm")
                  .Column<string>("PasswordSalt")
                  .Column<string>("RegistrationStatus", c => c.WithDefault("Approved"))
                  .Column<DateTime>("CreatedUtc")
                  .Column<DateTime>("LastLoginUtc")
                  .Column<DateTime>("LastLogoutUtc")
              );
            return 1;
        }
    }
}