abstract class GeoObject
{
    protected double _x { get; set; }
    protected double _y { get; set; }
    protected string _description { get; set; }
    protected string _name { get; set; }
    public virtual void getInfo() 
    {
        Console.WriteLine($"x={_x}; y={_y} ; description={_description}; name={_name}");
    }

}

class River:GeoObject
{
    private double _speed { get; set; }
    private double _totalLength { get; set; }

    public River(double xTemp, double yTemp, string descriptionTemp, string nameTemp, double speedTemp, double totalLengthTemp)
    {
        _x = xTemp;
        _y = yTemp;
        _description = descriptionTemp;
        _name = nameTemp;
        _speed = speedTemp;
        _totalLength = totalLengthTemp;
    }
    public override void getInfo()
    {
        Console.WriteLine($"Info about {_name}{Environment.NewLine}x={_x}; y={_y}; description={_description}; name={_name}; total length={_totalLength} km; speed={_speed} km/s");
    }
}

class Mountain : GeoObject
{
    private string _highestPeak { get; set; }

    public Mountain(double xTemp, double yTemp, string descriptionTemp, string nameTemp, string highestPeakTemp)
    {
        _x = xTemp;
        _y = yTemp;
        _description = descriptionTemp;
        _name = nameTemp;
        _highestPeak = highestPeakTemp;
    } 
    public override void getInfo()
    {
        Console.WriteLine($"Info about {_name}{Environment.NewLine}x={_x}; y={_y}; description={_description}; name={_name}; highest peak={_highestPeak}");
    }

}

class Program

{
    static void Main(string[] args) { 
        Mountain mountain=new Mountain(35.880981, 76.508102, "It's very beautiful!", "K2", "Dhaulagiri I");
        River river =new River(48.450001, 34.983334, "It`s beautiful!", "Dnipro", 2, 2.201);
        river.getInfo();
        mountain.getInfo();


    }
    
}
