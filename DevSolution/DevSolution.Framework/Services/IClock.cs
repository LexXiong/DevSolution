using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSolution.Caching;

namespace DevSolution.Services
{
    /// <summary>
    /// 提供当前的Utc时间<see cref="DateTime"/>, 和时间相关的缓存管理。
    /// 一旦需要当前的日期和时间，应使用该服务，而不是直接使用<seealso cref="DateTime"/>。
    /// 这也使得实现的可测试性，并且时间可以模拟。
    /// </summary>
    public interface IClock : IVolatileProvider
    {
        /// <summary>
        /// 获取当前的系统的<see cref="DateTime"/>，以UTC表示。
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        /// 提供了一个 <see cref="IVolatileToken"/> 实例可用于缓存的特定时间的一些信息。
        /// </summary>
        /// <param name="duration">The duration that the token must be valid.</param>
        /// <example>
        /// This sample shows how to use the <see cref="When"/> method by returning the result of
        /// a method named LoadVotes(), which is computed every 10 minutes only.
        /// <code>
        /// _cacheManager.Get("votes",
        ///     ctx => {
        ///         ctx.Monitor(_clock.When(TimeSpan.FromMinutes(10)));
        ///         return LoadVotes();
        /// });
        /// </code>
        /// </example>
        IVolatileToken When(TimeSpan duration);

        /// <summary>
        /// Provides a <see cref="IVolatileToken"/> instance which can be used to cache some 
        /// until a specific date and time.
        /// </summary>
        /// <param name="absoluteUtc">The date and time that the token must be valid until.</param>
        /// <example>
        /// This sample shows how to use the <see cref="WhenUtc"/> method by returning the result of
        /// a method named LoadVotes(), which is computed once, and no more until the end of the year.
        /// <code>
        /// var endOfYear = _clock.UtcNow;
        /// endOfYear.Month = 12;
        /// endOfYear.Day = 31;
        /// 
        /// _cacheManager.Get("votes",
        ///     ctx => {
        ///         ctx.Monitor(_clock.WhenUtc(endOfYear));
        ///         return LoadVotes();
        /// });
        /// </code>
        /// </example>
        IVolatileToken WhenUtc(DateTime absoluteUtc);
    }
}
