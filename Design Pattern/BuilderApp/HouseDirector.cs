using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderApp;

public class HouseDirector {
    public HouseBuilder Builder { private get; set; }

    public HouseDirector(HouseBuilder builder) => this.Builder = builder;

    public House MakeSimpleHouse() {
        return this.Builder
            .BuildWindows(4)
            .BuildDoors(2)
            .BuildWalls(8)
            .BuildGarage()
            .PlantDecoration(new Decoration("Tree"))
            .Build();
    }
}