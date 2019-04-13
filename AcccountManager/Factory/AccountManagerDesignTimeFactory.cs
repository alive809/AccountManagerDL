
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace AcccountManager.Factory
{
    public class AccountManagerDesignTimeFactory :
        IDesignTimeDbContextFactory<AcountManagerDBContext>
    {
        int i = 1;
        public AcountManagerDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AcountManagerDBContext>();

            //optionsBuilder.UseSqlServer(@"Server=.; Database=AccountManagerDB_AL;Integrated Security = true");

            if (i == 1)
            {
                optionsBuilder.UseMySQL("server=localhost;database=prueba;user=root;pwd=123456789",
                    option=> option.MigrationsAssembly(typeof(AcountManagerDBContext).Assembly.FullName));
            }
            else
            {
                optionsBuilder.UseSqlServer(@"Server=.; Database=AccountManagerDB_AL;Integrated Security = true",
                    option=> option.MigrationsAssembly( typeof(AcountManagerDBContext).Assembly.FullName));
            }


            return new AcountManagerDBContext(optionsBuilder.Options);
        }

    /*    public AcountManagerDBContext CreateDbContext(string[]args, string[]args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AcountManagerDBContext>();
            optionsBuilder.UseMySQL(@"User ID=root;Password=myPassword;Host=localhost;Port=3306;Database=myDataBase;
Direct=true;Protocol=TCP;Compress=false;Pooling=true;Min Pool Size=0;
Max Pool Size=100;Connection Lifetime=0;");
            return new AcountManagerDBContext(optionsBuilder.Options);
        }*/
    }
}
