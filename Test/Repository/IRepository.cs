using System.Collections.Generic;

namespace Test
{
    public interface IRepository
    {
        IEnumerable<Users> Users { get; }
    }
}