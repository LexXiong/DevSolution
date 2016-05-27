using System;

namespace Boying.Data
{
    /// <summary>
    /// Mark a property to be excluded from NHibernate mapping
    /// </summary>
    /// <example>
    /// public class Person {
    ///     public virtual int Id { get; set; }
    ///     public virtual string FirstName { get; set; }
    ///     public virtual string LastName { get; set; }
    ///     [NotMapped]
    ///     public virtual string FullName { get {return Fullname+", "+LastName;} }
    /// }
    /// </example>
    public class NotMappedAttribute : Attribute
    {
    }
}