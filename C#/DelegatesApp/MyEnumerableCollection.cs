using System.Collections;

namespace DelegatesApp;


class Enumerator : IEnumerator<int> {
    private int current;

    public int Current {
        get {
            return current++;
        }
    }

    object IEnumerator.Current {
        get {
            return current++;
        }
    }

    public void Dispose() {

    }

    public bool MoveNext() {
        if (this.Current < 1000) {
            return true;
        }
        else {
            this.Reset();
            return false;
        }
    }

    public void Reset() {
        Console.WriteLine("END");
        this.current = 0;
    }
}

class MyEnumerableCollection : IEnumerable<int> {
    private IEnumerator<int> enumerator;

    public MyEnumerableCollection() {
        this.enumerator = new Enumerator();
    }

    public IEnumerator<int> GetEnumerator() {
        return this.enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.enumerator;
    }
}
