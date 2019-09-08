namespace CheckIt.Core.Utils.Navigation
{
    public sealed class NavigationArgs
    {
        public string PageKey { get; set; }

        public BasePageParameters PageParameters { get; set; }

        public bool Animated { get; set; } = true;
    }
}
