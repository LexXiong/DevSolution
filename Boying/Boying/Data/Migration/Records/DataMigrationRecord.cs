namespace Boying.Data.Migration.Records
{
    public class DataMigrationRecord : ContentRecord
    {
        public virtual string DataMigrationClass { get; set; }

        public virtual int? Version { get; set; }
    }
}