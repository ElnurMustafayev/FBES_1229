namespace InterfacesApp;

interface I1 {
    string Func();
}

interface I2 {
    int Func();
}

class A : I1, I2 {
    string I1.Func() {
        throw new NotImplementedException();
    }

    public int Func() {
        this.Func();

        return 0;
    }
}