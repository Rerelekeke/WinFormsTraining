using System;

interface IControl
{
    void Paint();
}
interface ISurface
{
    void Paint();
}
class SampleClass : IControl, ISurface
{
    public void Paint()
    {
        Console.WriteLine("General painting");
    }

    void IControl.Paint()
    {
        Console.WriteLine("IControl painting");
    }
    void ISurface.Paint()
    {
        Console.WriteLine("IControl painting");
    }
}
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Appel de Paint depuis IControl
//        IControl myControl = new SampleClass();
//        myControl.Paint();

//        // Appel de Paint depuis ISurface
//        ISurface mySurface = new SampleClass();
//        mySurface.Paint();
//    }
//}
