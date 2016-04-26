﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSolution.Caching;

namespace DevSolution.Services
{
    public class Clock : IClock
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        public IVolatileToken When(TimeSpan duration)
        {
            return new AbsoluteExpirationToken(this, duration);
        }

        public IVolatileToken WhenUtc(DateTime absoluteUtc)
        {
            return new AbsoluteExpirationToken(this, absoluteUtc);
        }

        /// <summary>
        /// 绝对过期令牌
        /// </summary>
        public class AbsoluteExpirationToken : IVolatileToken
        {
            private readonly IClock _clock;
            private readonly DateTime _invalidateUtc;

            public AbsoluteExpirationToken(IClock clock, DateTime invalidateUtc)
            {
                _clock = clock;
                _invalidateUtc = invalidateUtc;
            }

            public AbsoluteExpirationToken(IClock clock, TimeSpan duration)
            {
                _clock = clock;
                _invalidateUtc = _clock.UtcNow.Add(duration);
            }

            public bool IsCurrent
            {
                get
                {
                    return _clock.UtcNow < _invalidateUtc;
                }
            }
        }
    }
}