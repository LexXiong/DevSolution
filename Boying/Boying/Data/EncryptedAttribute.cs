using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boying.Data
{
    /// <summary>
    /// Mark a property will be encrypted
    /// </summary>
    /// <example>
    /// public class Person {
    ///     public virtual int Id { get; set; }
    ///     public virtual string FirstName { get; set; }
    ///     public virtual string LastName { get; set; }
    ///     [Encrypt]
    ///     public virtual string Mobile { get; set; }
    /// }
    /// </example>
    public class EncryptedAttribute : Attribute
    {
    }
}