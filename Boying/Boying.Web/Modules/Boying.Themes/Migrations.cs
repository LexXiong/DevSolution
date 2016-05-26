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
                .ContentPartRecord()
                .Column("CurrentThemeName", DbType.String)
            );

            return 1;
        }
    }
}