using System;

namespace Boying.FileSystems.LockFile
{
    public interface ILockFile : IDisposable
    {
        void Release();
    }
}