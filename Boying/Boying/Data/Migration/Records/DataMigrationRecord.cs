namespace Boying.Data.Migration.Records
{
    public class DataMigrationRecord : ContentPartRecord
    {
        public virtual string DataMigrationClass { get; set; }

        public virtual int? Version { get; set; }
    }
}