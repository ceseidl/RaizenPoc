using System.Reflection;

namespace Api.Helpers
{
    public static class PropertyCache<T>
    {
        private static readonly Lazy<IReadOnlyCollection<PropertyInfo>> publicPropertiesLazy
            = new Lazy<IReadOnlyCollection<PropertyInfo>>(() => typeof(T).GetProperties());

        public static IReadOnlyCollection<PropertyInfo> PublicProperties => PropertyCache<T>.publicPropertiesLazy.Value;
    }
}
