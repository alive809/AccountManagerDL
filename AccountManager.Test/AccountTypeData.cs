using AcccountManager;
using AcccountManager.Factory;
using AcccountManager.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AccountManager.Test
{
    [TestClass]
    public class AccountTypeData
    {
        private AcountManagerDBContext context;

        public AccountTypeData()
        {
            var factory = new AccountManagerDesignTimeFactory();
            context = factory.CreateDbContext(new string[] { });
            context.Database.Migrate();
        }
        [TestMethod]
        public void AddOK()
        {
            int rowsAffected = 0;
            AccountType accountType = new AccountType
            {
                code = "ACT",
                name = "Activos"
            };

            context.AccountTypes.Add(accountType);

            if (context.ChangeTracker.HasChanges())
                rowsAffected = context.SaveChanges();

            Assert.AreNotEqual(0, rowsAffected);
        }

    }
}
