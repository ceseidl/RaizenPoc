namespace Api.Helpers
{
    public static class Extensions
    {
        public static bool ArePropertiesNotNull<T>(this T obj)
        {
            return PropertyCache<T>.PublicProperties.All(propertyInfo => propertyInfo.GetValue(obj) != null);
        }
    }
}
