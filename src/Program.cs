namespace MyApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /// Expected output: "A B"
            /// Actual output: "AB"
            Console.Error.Write('A');
            Console.Error.Write(' ');
            Console.Error.Write('B');

            // Outputs "A B" as expected
            // Console.Error.Write("A B");

            /// Expected output: "Line 1" and "Line 2" on separate lines
            /// Actual output: "Line 1Line 2"
            // Console.Error.Write("Line 1");
            // Console.Error.Write(Environment.NewLine);
            // Console.Error.Write("Line 2");

            // Outputs "Line 1" and "Line 2" on separate lines as expected
            // Console.Error.Write("Line 1" + Environment.NewLine + "Line 2");
        }
    }
}