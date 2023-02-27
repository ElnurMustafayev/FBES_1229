using System.Collections;

namespace ExtensionMethodsApp;

public class MyCollection<T> : IEnumerable<T> {
    public IEnumerable<T> Data;

    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        throw new NotImplementedException();
    }
}