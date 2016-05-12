using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boying.DisplayManagement.Shapes
{
    public interface ITagBuilderFactory : IDependency
    {
        BoyingTagBuilder Create(dynamic shape, string tagName);
    }

    public class BoyingTagBuilder : TagBuilder
    {
        public BoyingTagBuilder(string tagName) : base(tagName)
        {
        }

        public IHtmlString StartElement { get { return new HtmlString(ToString(TagRenderMode.StartTag)); } }

        public IHtmlString EndElement { get { return new HtmlString(ToString(TagRenderMode.EndTag)); } }

        public IHtmlString ToHtmlString(TagRenderMode renderMode = TagRenderMode.Normal)
        {
            return new HtmlString(ToString(renderMode));
        }
    }

    public class TagBuilderFactory : ITagBuilderFactory
    {
        public BoyingTagBuilder Create(dynamic shape, string tagName)
        {
            var tagBuilder = new BoyingTagBuilder(tagName);
            tagBuilder.MergeAttributes(shape.Attributes, false);
            foreach (var cssClass in shape.Classes ?? Enumerable.Empty<string>())
                tagBuilder.AddCssClass(cssClass);
            if (!string.IsNullOrEmpty(shape.Id))
                tagBuilder.GenerateId(shape.Id);
            return tagBuilder;
        }
    }
}