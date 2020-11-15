using FluentMigrator;

namespace Rcgnzr.Cabinet.Migrator.Migrations
{
    [Migration(20201115174500)]
    public class AddUsers: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt64().PrimaryKey()
                .WithColumn("Name").AsString()
                .WithColumn("Login").AsString().Unique()
                .WithColumn("PasswordHash").AsString();
        }
    }
}