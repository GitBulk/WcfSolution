using System;

namespace Data.Core.Infrastructures
{
    public interface IDbFactory : IDisposable
    {
        BlogContext Init();
    }
}
