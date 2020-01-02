using Net.FreeORM.Base;
using System;

namespace Net.FreeORM.Entity.QueryBuilding
{
    internal interface IQueryBuilder
    {
        /// <summary>
        /// Gets Property contains parameter(s).
        /// </summary>
        Property Properties { get; }

        /// <summary>
        /// Gets Sql Query.
        /// </summary>
        String QueryString { get; }

    }
}