using Boying.Data;
using Boying.Security;
using Boying.UI.Notify;

namespace Boying
{
    /// <summary>
    /// Most important parts of the Boying API
    /// </summary>
    public interface IBoyingServices : IDependency
    {
        //IContentManager ContentManager { get; }
        ITransactionManager TransactionManager { get; }

        IAuthorizer Authorizer { get; }

        INotifier Notifier { get; }

        /// <summary>
        /// Shape factory
        /// </summary>
        /// <example>
        /// dynamic shape = New.ShapeName(Parameter: myVar)
        ///
        /// Now the shape can used in various ways, like returning it from a controller action
        /// inside a ShapeResult or adding it to the Layout shape.
        ///
        /// Inside the shape template (ShapeName.cshtml) the parameters can be accessed as follows:
        /// @Model.Parameter
        /// </example>
        dynamic New { get; }

        WorkContext WorkContext { get; }
    }
}