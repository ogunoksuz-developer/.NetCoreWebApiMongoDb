using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public  class MongoDbSettings
    {
        public string ConnectionString;
        public string Database;


        public const string ConnectionStringValue = nameof(ConnectionString);
        public const string DatabaseValue = nameof(Database);

    }
}
