namespace ISerializer
{
        public interface ISerializer<T>
        {
            string Serialize(T target);
        }
    }


