using System.Reflection;

namespace Domain.Extensions;

public static class MappExtensions
{
    public static TDestination MapTo<TDestination>(this object source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        TDestination destination = (TDestination)Activator.CreateInstance(typeof(TDestination))!;

        var SourceProperties = source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var DestinationProperties = destination.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach ( var destinationProperty in DestinationProperties)
        {
            var sourceProperty = SourceProperties.FirstOrDefault(x => x.Name == destinationProperty.Name && x.PropertyType == destinationProperty.PropertyType);
            if (sourceProperty != null && destinationProperty.CanWrite)
            {
                var value = sourceProperty.GetValue(source);
                destinationProperty.SetValue(destination, value);
            }
        }

        return destination;
    }
}
