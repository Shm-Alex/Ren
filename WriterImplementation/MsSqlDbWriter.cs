using System.Data.SqlClient;
using System.Threading.Tasks;
using IRepository;
using Dapper;
namespace WriterImplementation
{
    public class MsSqlDbWriter : IWriter
    {
        private readonly string _connection;

        public MsSqlDbWriter(string connection)
        {
            _connection = connection;
        }
        public async Task WriteAsync(string subject)
        {
            using (var cnn = new SqlConnection(_connection))
            {
                var ret = await cnn.QueryAsync("Insert into XmlTable values(@Xml) ", new { Xml = subject });
            };
        }
    }
}
