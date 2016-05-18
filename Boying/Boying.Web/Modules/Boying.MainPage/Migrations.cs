using System;
using System.Collections.Generic;
using System.Data;
using Boying.Data.Migration;

namespace Boying.MainPage
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("Users", table => table
                .Column<int>("Id", c => c.PrimaryKey().Identity())
                .Column<string>("Name", c => c.WithLength(20).NotNull())
                .Column<int>("Age")
            );
            return 1;
        }
    }
}