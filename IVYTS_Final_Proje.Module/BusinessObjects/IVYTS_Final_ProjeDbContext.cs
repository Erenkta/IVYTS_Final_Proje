using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using VYTSFinalProje.Module.BusinessObjects;


namespace IVYTS_Final_Proje.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class IVYTS_Final_ProjeContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<IVYTS_Final_ProjeEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new IVYTS_Final_ProjeEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class IVYTS_Final_ProjeDesignTimeDbContextFactory : IDesignTimeDbContextFactory<IVYTS_Final_ProjeEFCoreDbContext> {
	public IVYTS_Final_ProjeEFCoreDbContext CreateDbContext(string[] args) {
		//throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		var optionsBuilder = new DbContextOptionsBuilder<IVYTS_Final_ProjeEFCoreDbContext>();
		optionsBuilder.UseSqlServer("Integrated Security=SSPI;Data Source=DESKTOP-ALSQEP4;Initial Catalog=IVYTS_Final_Proje;TrustServerCertificate=True");
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
		return new IVYTS_Final_ProjeEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(IVYTS_Final_ProjeContextInitializer))]
public class IVYTS_Final_ProjeEFCoreDbContext : DbContext {
	public IVYTS_Final_ProjeEFCoreDbContext(DbContextOptions<IVYTS_Final_ProjeEFCoreDbContext> options) : base(options) {
	}
    public DbSet<OriginalCarData> OriginalCarData { get; set; }
    public DbSet<OneHotEncodedCarData> OneHotEncodedCarData { get; set; }
    public DbSet<X_Test> X_Test { get; set; }
    public DbSet<X_Test_Scaled> X_Test_Scaled { get; set; }
    public DbSet<X_Train> X_Train { get; set; }
    public DbSet<X_Train_Scaled> X_Train_Scaled { get; set; }
    public DbSet<Y_Test> Y_Test { get; set; }
    public DbSet<Y_Train> Y_Train { get; set; }
    public DbSet<Test_Prediction> Test_Prediction { get; set; }
    public DbSet<Trained_Prediction> Trained_Prediction { get; set; }
    public DbSet<Random_Data> Random_Data { get; set; }
    public DbSet<Random_Data_Scaled> Random_Data_Scaled { get; set; }
    public DbSet<Random_Data_Prediction> Random_Data_Prediction { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        base.OnModelCreating(modelBuilder);
    }
}
