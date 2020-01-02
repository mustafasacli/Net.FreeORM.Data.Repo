using Net.FreeORM.Logic.BaseDal;

namespace BookmarksStocker.Source.DL
{
    internal class BookmarksDL : BaseDL
    {
        internal BookmarksDL()
            : base("sqlce")
        {
        }
        /*
        public override int InsertAndGetId(BaseBO baseBO)
        {
            try
            {
                int insertResult = base.Insert(baseBO);
                if (insertResult == 1)
                {
                    QueryTypes.Identity --> deprecated (means replaced with InsertAndGetId)
                    QueryBuilder qB = CreateQueryBuilder(QueryTypes.Identity, baseBO);
                    insertResult = ExecuteScalarAsQuery(qB.QueryString).ToInt();
                }
                else
                {
                    insertResult = 0;
                }

                return insertResult;
            }
            catch (Exception)
            {
                throw;
            }
        }
        */
    }
}