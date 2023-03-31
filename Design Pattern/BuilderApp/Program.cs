namespace BuilderApp {
    public class Program {
        static void Main() {
            //House h = new House(8, 4, 2);

            HouseBuilder builder = new HouseBuilder();
            
            var simpleHouse = builder.BuildWindows(4)
                .BuildDoors(2)
                .BuildWalls(8)
                .BuildGarage()
                .Build();

            var houseWithRoof = builder
                .BuildRoof()
                .PlantDecoration(new Decoration("Tree"))
                .Build();
        }
    }
}