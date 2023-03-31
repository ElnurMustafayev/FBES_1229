namespace BuilderApp;

public class HouseBuilder : IBuilder<House> {
    protected House house;

    public HouseBuilder() {
        this.house = new House();
    }

    public virtual HouseBuilder BuildWalls(int count) {
        this.house.WallsCount += count;
        return this;
    }

    public virtual HouseBuilder BuildWindows(int count) {
        this.house.WindowsCount += count;
        return this;
    }

    public virtual HouseBuilder BuildDoors(int count) {
        this.house.DoorsCount += count;
        return this;
    }

    public virtual HouseBuilder BuildRoof() {
        this.house.HasRoof = true;
        return this;
    }

    public virtual HouseBuilder BuildGarage() {
        this.house.HasGarage = true;
        return this;
    }

    public virtual HouseBuilder BuildSwimmingPool() {
        this.house.HasSwimmingPool = true;
        return this;
    }

    public virtual HouseBuilder PlantDecoration(Decoration decoration) {
        this.house.Decorations.Add(decoration);
        return this;
    }

    public virtual void Reset() => this.house = new House();

    public virtual House Build() {
        var result = this.house;
        this.Reset();
        return result;
    }
}