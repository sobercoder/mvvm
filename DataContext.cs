using System.Data.Entity;
using System.Data.SqlClient;

namespace TestApp.Model.Context
{
	public class DataContext : DbContext
	{
		private static string _connectionString = new SqlConnectionStringBuilder() {
			DataSource = @"workstation-pc\sqlexpress",
			InitialCatalog = "student-db",
			IntegratedSecurity = true,
		}.ToString();

		public DataContext() : base(_connectionString) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Student> Students { get; set; }
	}
}
