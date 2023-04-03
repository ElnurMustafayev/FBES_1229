namespace MultipleDecoratorApp.Model.Weapons;

public abstract class Weapon
{
    public virtual double Damage { get; set; }
    public virtual double Accuracy { get; set; }
    public virtual double Mobility { get; set; }
}