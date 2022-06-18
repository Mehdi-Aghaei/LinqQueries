<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// var pointA = Point.Factory.NewCartesianPoint(1,2).ToString();

public class Point
{
	private double x,y;
	
	private Point(double a, double b)
	{
		this.x = a ;
		this.y = b;
	}
	public override string ToString()
	{
		return $"{nameof(x)} : {x}, {nameof(y)}: {y}";
	}
	
	public static Point Origin => new Point(0,0); // origin prop
	public static Point Origin2 = new Point(0,0); // singelton is bettter
	
	// make factory usually static and we hide the ctor
	public static class Factory
	{
		public static Point NewCartesianPoint(double x, double y){
			return new Point(x,y);
		}
		
		public static Point NewPolarPoint(double rho,double theta){
			return new Point(rho* Math.Cos(theta),rho* Math.Sin(theta));
		}
	}
}
