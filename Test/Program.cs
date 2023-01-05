namespace Test
{
    // { 2023.01.5 Modified class Position /Alpa
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
        // { 2023.01.5 Modified class Position /Alpa
        public class Ruler
        {
            private const float ONE_INCH = 2.54f;
            public int Centimeter { get; set; } = 0;

            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                private set { Centimeter = (int)(value / ONE_INCH); }
            }

            public Ruler(int cmValue) { Centimeter = cmValue; }

            public void Run()
            {
                Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
            }

        }

    }
}