namespace LINQApp;

public static class Extensions {
    public static bool MyAny<T>(this IEnumerable<T> collection) {
        if (collection == null)
            return false;

        return collection.Count() > 0;
    }

    public static bool MyAny<T>(this IEnumerable<T> collection, Func<T, bool> predicate) {
        if (collection.MyAny() == false)
            return false;

        foreach (var item in collection) {
            if (predicate.Invoke(item))
                return true;
        }
        return false;
    }
}