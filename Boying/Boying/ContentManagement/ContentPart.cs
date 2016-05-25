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
    public class ContentPart : DynamicObject, IContent
    {
        public int Id { get; set; }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var found = base.TryGetMember(binder, out result);
            if (!found)
            {
                //foreach (var part in ContentItem.Parts)
                //{
                //    if (part.PartDefinition.Name == binder.Name)
                //    {
                //        result = part;
                //        return true;
                //    }
                //}

                //foreach (var field in Fields)
                //{
                //    if (field.PartFieldDefinition.Name == binder.Name)
                //    {
                //        result = field;
                //        return true;
                //    }
                //}
                result = null;
                return true;
            }

            return true;
        }

        public T Retrieve<T>(string fieldName)
        {
            //return InfosetHelper.Retrieve<T>(this, fieldName);
            return default(T);
        }

        public T RetrieveVersioned<T>(string fieldName)
        {
            //return this.Retrieve<T>(fieldName, true);
            return default(T);
        }

        public virtual void Store<T>(string fieldName, T value)
        {
            //InfosetHelper.Store(this, fieldName, value);
        }

        public virtual void StoreVersioned<T>(string fieldName, T value)
        {
            //this.Store(fieldName, value, true);
        }
    }

    public class ContentPart<TRecord> : ContentPart
    {
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