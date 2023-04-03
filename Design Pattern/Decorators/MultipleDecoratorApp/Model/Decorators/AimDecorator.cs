using MultipleDecoratorApp.Model.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDecoratorApp.Model.Decorators;

public class AimDecorator : WeaponDecorator {
    public AimDecorator(Weapon wrapper) : base(wrapper) {
        this.accuracy = 30;
        this.mobility = -3;
    }
}