namespace PRG2_UE04_1
{
    public class PRG2_UE04_1
    {
        public static void Main()
        {
            char input = ' ';
            while(input != 'x' && input != 'X')
            {
                printMenu();
                input = (char)Console.Read();

                int selection = 0;
                if (int.TryParse(input.ToString(),out selection))
                {
                    switch(selection)
                    {
                        case 1:
                            int number1 = 2;
                            int number2 = 4;
                            SwapValues(ref number1, ref number2);
                            Console.WriteLine($"Ergebnis: \n Zahl 1: {number1} \n Zahl 2: {number2}" );
                            break;
                        case 2:
                            double capital = 100.00;
                            int runtime = 3;
                            double interestRate = 0.1;
                            Console.WriteLine($"Ergebnis: {CalculateInterest(capital, runtime, interestRate)}");
                            break;
                        case 3:
                            double a = 6.9;
                            double b = 4.2;
                            Console.WriteLine($"Ergebnis: {CalcHypotenuse(a, b)}");
                            break;
                        case 4:
                            double radius = 2.1;
                            double height = 5;
                            double area, volume;
                            CalcCylinder(radius, height, out area, out volume);
                            Console.WriteLine($"Ergebnis: \n Volumen: {volume} \n Oberfläche: {area}");
                            break;
                        case 5:
                            int[] inputValues = new int[] { 2, 200, 151, 900, 15 };
                            int minimum = 1;
                            int maximum = 200;
                            Console.WriteLine($"Ergebnis: {CountBetween(inputValues, minimum, maximum)}");
                            break;
                        case 6:
                            int startValue = 0;
                            int increment = 5;
                            int valueCount = 6;
                            int[] result = CreateSeries(startValue, increment, valueCount);
                            
                            Console.Write("Ergebnis: { ");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.Write(result[i]);
                                if(i != result.Length - 1)
                                {
                                    Console.Write(", ");
                                }
                            }
                            Console.WriteLine(" }");
                            break;
                        case 7:
                            int wedgeSize = 13;
                            PrintWedge(wedgeSize);
                            break;
                    }
                    Console.ReadLine();
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
        }

        private static void PrintWedge(int wedgeSize)
        {
            for (int i = 0; i < wedgeSize; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static int[] CreateSeries(int startValue, int increment, int valueCount)
        {
            int[] resultSet = new int[valueCount];
            for (int i = 0; i < valueCount; i++)
            {
                resultSet[i] = startValue + (i * increment);
            }
            return resultSet;
        }
        private static int CountBetween(int[] inputValues, int minimum, int maximum)
        {
            if(minimum > maximum)
            {
                int helper = minimum;
                minimum = maximum;
                maximum = helper;
            }

            int result = 0;
            for (int i = 0; i < inputValues.Length; i++)
            {
                if(inputValues[i] >= minimum && inputValues[i] <= maximum)
                {
                    result++;
                }
            }
            return result;
        }
        private static void CalcCylinder(double radius, double height, out double area, out double volume)
        {
            double baseArea = Math.PI * Math.Pow(radius, 2);
            volume = baseArea * height;
            area = 2 * baseArea + (2 * Math.PI * radius * height);
        }
        private static void SwapValues(ref int number1, ref int number2)
        {
            int helper = 0;
            helper = number1;
            number1 = number2;
            number2 = helper;
        }
        private static double CalculateInterest(double capital, int runtime, double interestRate)
        {
            for( int i = 0; i < runtime; i ++)
            {
                capital = capital + (capital  * interestRate);
            }
            return capital;
        }
        private static double CalcHypotenuse(double a, double b)
        {
            return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
        public static void printMenu()
        {
            Console.WriteLine("Bitte wählen Sie die Funktion mit Nummer:");
            Console.WriteLine("1 - Vertauschen von 2 Zahlen");
            Console.WriteLine("2 - Zinsberechnung");
            Console.WriteLine("3 - Länge der Hypotenuse bzw.Pythagoras");
            Console.WriteLine("4 - Zylinderberechnungen");
            Console.WriteLine("5 - Zählenwenn");
            Console.WriteLine("6 - Serie");
            Console.WriteLine("7 - Keil");
            Console.WriteLine("X - Beenden");
            Console.WriteLine();
            Console.Write("Auswahl: ");
        }
    }
}