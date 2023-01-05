namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }

        public class Ruler
        {
            private const float ONE_INCH = 2.54f;
            public int Centimeter { get; set; } = 0;

            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                // { 2023.01.05         Add new feature SeyInch func    / Gamma
                private set { SetInch(value); }
            }

            public Ruler(int cmValue) { Centimeter = cmValue; }

            public void Run()
            {
                Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
            }
            
            private void SetInch(float inchValue)
            {
                Centimeter = (int)(inchValue / ONE_INCH);
            }
            // } 2023.01.05         Add new feature SeyInch func    / Gamma
        }

    }
}