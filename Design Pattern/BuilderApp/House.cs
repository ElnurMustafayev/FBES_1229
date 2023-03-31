namespace BuilderApp;

public class Decoration {
    public string Name { get; set; }

    public Decoration(string name) {
        this.Name = name;
    }
}

public class House {
    public int WallsCount { get; set; }
    public int WindowsCount { get; set; }
    public int DoorsCount { get; set; }
    public bool HasRoof { get; set; }
    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }
    public ICollection<Decoration> Decorations { get; set; }

    public House() {
        this.Decorations = new List<Decoration>();
    }

    public House(int wallsCount, int windowsCount, int doorsCount, bool hasRoof, bool hasGarage, bool hasSwimmingPool, ICollection<Decoration> decorations) : this() {
        this.WallsCount = wallsCount;
        this.WindowsCount = windowsCount;
        this.DoorsCount = doorsCount;
        this.HasRoof = hasRoof;
        this.HasGarage = hasGarage;
        this.HasSwimmingPool = hasSwimmingPool;
        this.Decorations = decorations ?? new List<Decoration>();
    }
}