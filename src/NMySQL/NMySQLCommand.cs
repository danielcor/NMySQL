#region License
// The source code contained in this file is goverened under the Revised BSD "3-Clause" License.
// See the file "LICENSE" for the full license governing this code.
#endregion

using System;
using System.Data;
using System.Data.Common;

namespace NMySQL
{
    public sealed class NMySQLCommand : DbCommand
    {
        private string commandText;
        private int commandTimeout;
        private CommandType commandType;

        public override string CommandText
        {
            get
            {
                return commandText;
            }
            set
            {
                commandText = value;
            }
        }

        public override int CommandTimeout { get; set; }

        public override CommandType CommandType
        {
            get
            {
                return commandType;
            }

            set
            {
                commandType = value;
            }
        }

        public override bool DesignTimeVisible
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override UpdateRowSource UpdatedRowSource
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        protected override DbConnection DbConnection
        {
            get
            {
                return Connection;
            }
            set
            {
                Connection = (NMySQLConnection)value;
            }
        }

        protected override DbParameterCollection DbParameterCollection { get; }

        protected override DbTransaction DbTransaction
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        public override object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }

        #region Parameters

        protected override DbParameter CreateDbParameter()
        {
            return CreateParameter();
        }

        protected new NMySQLParameter CreateParameter()
        {
            return new NMySQLParameter();
        }

        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}