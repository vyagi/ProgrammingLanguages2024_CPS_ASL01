namespace InvoiceApplication.BusinessLogic.Tests.Tools;

public static class LinqExtensions
{
    public static T Second<T>(this IEnumerable<T> source) => source.Skip(1).First();
    public static T Third<T>(this IEnumerable<T> source) => source.Skip(2).First();
}
