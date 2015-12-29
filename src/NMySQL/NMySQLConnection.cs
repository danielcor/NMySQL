#region License
// The source code contained in this file is goverened under the Revised BSD "3-Clause" License.
// See the file "LICENSE" for the full license governing this code.
#endregion

using System;
using System.Data;
using System.Data.Common;

namespace NMySQL
{
    public sealed partial class NMySQLConnection : DbConnection
    {
        public override string ConnectionString { get; set; }

        public NMySQLConnectionStringBuilder ConnectionStringBuilder { get; set; }
        public override string Database
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string DataSource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ServerVersion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ConnectionState State
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}