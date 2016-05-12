namespace Boying.Localization
{
    public static class NullLocalizer
    {
        static NullLocalizer()
        {
            _instance = (format, args) => new LocalizedString((args == null || args.Length == 0) ? format : string.Format(format, args));
        }

        private static readonly Localizer _instance;

        public static Localizer Instance { get { return _instance; } }
    }
}