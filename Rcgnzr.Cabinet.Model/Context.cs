using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace Rcgnzr.Cabinet.Model
{
    public class Context : DataConnection
    {
        private static MappingSchema _mappingSchema;

        public Context(string connectionString) : base(LinqToDB.ProviderName.MySql, connectionString)
        {
            if (_mappingSchema == null)
                _mappingSchema = InitContextMappings(MappingSchema);
        }

        public ITable<User> Users => GetTable<User>();

        private static MappingSchema InitContextMappings(MappingSchema ms)
        {
            ms.GetFluentMappingBuilder()
                .Entity<User>()
                .HasTableName("Users")
                .HasPrimaryKey(x => x.Id).HasIdentity(x=>x.Id)
                .HasColumn(x=>x.Login)
                .HasColumn(x=>x.PasswordHash)
                .HasColumn(x=>x.Name);
            
            return ms;
        }
    }
}