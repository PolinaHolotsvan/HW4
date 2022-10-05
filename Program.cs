abstract class GeoObject
{
    protected double x { get; set; }
    protected double y { get; set; }
    protected string description { get; set; }
    protected string name { get; set; }
    public virtual void getInfo() {
        Console.WriteLine("x=" + this.x + "; y=" + this.y + "; description=" + this.description + "; name=" + this.name );
    }


}

class River:GeoObject
{
    protected double speed { get; set; }
    protected double totalLength { get; set; }

    public River(double xTemp, double yTemp, string descriptionTemp, string nameTemp, double speedTemp, double totalLengthTemp)
    {
        this.x = xTemp;
        this.y = yTemp;
        this.description = descriptionTemp;
        this.name = nameTemp;
        this.speed = speedTemp;
        this.totalLength = totalLengthTemp;
    }
    public River() { }
    public override void getInfo()
    {
        Console.WriteLine("x="+this.x+"; y="+this.y+"; description="+this.description+"; name="+this.name+"; total length="+this.totalLength+"km; speed="+this.speed+"km/s");
    }
}

class Mountain : GeoObject
{
    protected string highestPeak { get; set; }
    public override void getInfo()
    {
        Console.WriteLine("x=" + this.x + "; y=" + this.y + "; description=" + this.description + "; name=" + this.name + "; hightest peak:" +this.highestPeak);
    }

}

class Program

{
    static void Main(string[] args) { 
        Mountain mountain=new Mountain();
        River river =new River(3.2, 4.5, "it beautiful!", "Dnipro", 20, 1000);
        River riv = new River();
        river.getInfo();
    }
    
}
