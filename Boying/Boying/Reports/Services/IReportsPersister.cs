using System.Collections.Generic;

namespace Boying.Reports.Services
{
    /// <summary>
    /// Defines a service that can be used to persist reports.
    /// </summary>
    /// <remarks>
    /// Implementations of this interface are commonly used from <see cref="Boying.Reports.Services.IReportsManager"/> implementations.
    /// </remarks>
    public interface IReportsPersister : IDependency
    {
        IEnumerable<Report> Fetch();

        void Save(IEnumerable<Report> reports);
    }
}