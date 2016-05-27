using Boying.ContentManagement;

namespace Boying.Security
{
    /// <summary>
    /// Interface provided by the "User" model.
    /// </summary>
    public interface IUser : IContent
    {
        string Mobile { get; }

        string Email { get; }
    }
}