using System;
using System.Threading.Tasks;
using IRepository;
using ISerializer;

namespace Repository
{
    public class UserRepository<T> : IUserRepository<T>
    {
        private readonly IWriter _writer;
        private readonly ISerializer<T> _serializer;

        public UserRepository(IWriter writer, ISerializer<T> serializer)
        {
            _writer = writer;
            _serializer = serializer;
        }


        public async Task SaveAsXmlAsync(T dto)
        {
            var serialized = _serializer.Serialize(dto);
            await _writer.WriteAsync(serialized);
        }
    }

}
