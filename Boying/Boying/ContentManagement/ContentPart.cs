using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Boying.ContentManagement.Utilities;

namespace Boying.ContentManagement
{
    public abstract class ContentPart<TRecord> : IContent
    {
        public abstract int Id { get; set; }

        public readonly LazyField<TRecord> _record = new LazyField<TRecord>();

        public TRecord Record
        {
            get { return _record.Value; }
            set { _record.Value = value; }
        }
    }
}