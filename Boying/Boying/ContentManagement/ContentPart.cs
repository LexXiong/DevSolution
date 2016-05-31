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
    public class ContentPart<TRecord> : DynamicObject, IContent
    {
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        static ContentPart()
        {
        }

        protected TProperty Retrieve<TProperty>(Expression<Func<TRecord, TProperty>> targetExpression)
        {
            // return InfosetHelper.Retrieve(this, targetExpression);
            return default(TProperty);
        }

        protected TProperty Retrieve<TProperty>(
            Expression<Func<TRecord, TProperty>> targetExpression,
            Func<TRecord, TProperty> defaultExpression)
        {
            //return InfosetHelper.Retrieve(this, targetExpression, defaultExpression);
            return default(TProperty);
        }

        protected TProperty Retrieve<TProperty>(
                    Expression<Func<TRecord, TProperty>> targetExpression,
                    TProperty defaultValue)
        {
            //return InfosetHelper.Retrieve(this, targetExpression, (Func<TRecord, TProperty>)(x => defaultValue));
            return default(TProperty);
        }

        protected ContentPart<TRecord> Store<TProperty>(
            Expression<Func<TRecord, TProperty>> targetExpression,
            TProperty value)
        {
            //InfosetHelper.Store(this, targetExpression, value);
            return this;
        }

        public readonly LazyField<TRecord> _record = new LazyField<TRecord>();

        public TRecord Record { get { return _record.Value; } set { _record.Value = value; } }
    }
}