namespace ExtensionMethodsApp.Extensions;

public static class MyCollectionExtensions {
    public static int GetIndexByValue<T>(this MyCollection<T> collection, T value) {
        int counter = 0;
        foreach (var item in collection.Data) {
            if (item.Equals(value))
                return counter;
            counter++;
        }

        return -1;
    }
}