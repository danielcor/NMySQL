#region License
// The source code contained in this file is goverened under the Revised BSD "3-Clause" License.
// See the file "LICENSE" for the full license governing this code.
#endregion

using System.Data;
using System.Data.Common;

namespace NMySQL
{
    public sealed class NMySQLProviderFactory : DbProviderFactory
    {
        public override DbCommand CreateCommand()
        {
            return new NMySQLCommand();
        }

        public override DbConnection CreateConnection()
        {
            return new NMySQLConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new NMySQLConnectionStringBuilder();
        }

        public override DbParameter CreateParameter()
        {
            return new NMySQLParameter();
        }
    }
}