namespace InterfacesApp;

interface ICalc<TResult, TValue> {
    TResult Sum(TValue num1, TValue num2);
    TResult Minus(TValue num1, TValue num2);
}