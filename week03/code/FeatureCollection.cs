using System.Collections.Generic;

public class Properties {
    public string Place { get; set; }
    public double Mag { get; set; }
}

public class Geometry {
}

public class Feature {
    public string Type { get; set; }
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
}

public class FeatureCollection {
    public string Type { get; set; }
    public List<Feature> Features { get; set; }

    public FeatureCollection() {
        Features = new List<Feature>();
    }
}
