namespace AMB_Expenses.Data
{
    public class TransactionListEntity
    {
        
        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public List<TransactionEntity> Transactions { get; set; }
    }
}
