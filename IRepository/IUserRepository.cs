using System;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IUserRepository<T>
    {
        public Task SaveAsXmlAsync(T dto);
    }
    public interface IWriter
    {
        Task WriteAsync(string subject);
    }
}
