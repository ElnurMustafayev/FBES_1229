using MultipleDecoratorApp.Model.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDecoratorApp.Model.Decorators;

public class WeaponDecorator : Weapon {
    Weapon wrapper;

	protected double damage;
	protected double accuracy;
	protected double mobility;

    public override double Damage { get => wrapper.Damage + damage; }
    public override double Accuracy { get => wrapper.Accuracy + accuracy; }
    public override double Mobility { get => wrapper.Mobility + mobility; }

	public WeaponDecorator(Weapon wrapper) {
		this.wrapper = wrapper;
	}
}
