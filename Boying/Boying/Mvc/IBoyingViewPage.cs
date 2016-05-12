using System;
using System.Web;
using Boying.DisplayManagement.Shapes;
using Boying.Localization;
using Boying.UI.Resources;

namespace Boying.Mvc
{
    /// <summary>
    /// This interface ensures all base view pages implement the
    /// same set of additional members
    /// </summary>
    public interface IBoyingViewPage
    {
        Localizer T { get; }

        ScriptRegister Script { get; }

        ResourceRegister Style { get; }

        dynamic Display { get; }

        dynamic Layout { get; }

        IHtmlString DisplayChildren(object shape);

        WorkContext WorkContext { get; }

        IDisposable Capture(Action<IHtmlString> callback);

        void RegisterLink(LinkEntry link);

        void SetMeta(string name, string content, string httpEquiv, string charset);

        void SetMeta(MetaEntry meta);

        void AppendMeta(string name, string content, string contentSeparator);

        void AppendMeta(MetaEntry meta, string contentSeparator);

        bool HasText(object thing);

        BoyingTagBuilder Tag(dynamic shape, string tagName);
    }
}