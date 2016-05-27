using System;
using System.Collections.Generic;
using System.Data;
using Boying.Data.Migration;

namespace Boying.Themes
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            // Creating table ThemeSiteSettingsRecord
            SchemaBuilder.CreateTable("ThemeSiteSettingsRecord", table => table
                .Column<int>("Id", c => c.PrimaryKey().Identity())
                .Column<string>("CurrentThemeName")
            );

            return 1;
        }
    }
}