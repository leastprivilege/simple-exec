namespace SimpleExec
{
    using System.Reflection;

    internal static class DefaultPrefix
    {
        static DefaultPrefix()
        {
        }

        public static string Value = Assembly.GetEntryAssembly()?.GetName().Name ?? "SimpleExec";
    }
}
