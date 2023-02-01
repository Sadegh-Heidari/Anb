using Microsoft.EntityFrameworkCore;


namespace AMB_Expenses.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TransactionListEntity> TransactionLists { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=transactions.db");
        }
    }
  

}
