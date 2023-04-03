using MultipleDecoratorApp.Model.Weapons;

namespace MultipleDecoratorApp.Model.Decorators;

public class ButtDecorator : WeaponDecorator {
    public ButtDecorator(Weapon weapon) : base(weapon) {
        this.accuracy = 10;
        this.mobility = -5;
    }
}