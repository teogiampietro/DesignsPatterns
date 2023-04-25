using DP.FactoryPattern2.concrete;

namespace DP.FactoryPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string extension = ".TXT";

            switch (extension)
            {
                case ".TXT":
                    (bool Validation, string[] data) = ValidateFile(new ConcreteValidatorTxt());
                    Console.WriteLine(data);
                    break;
                case ".XML":
                    ValidateFile(new ConcreteValidatorXml());
                    break;
                default:
                    break;
            }
        }
        private static (bool Validation, string[] data) ValidateFile(Validator _file)
        {
            IFileValidator file = _file.Create();
            file.ContainsData();
            file.CanBeOpened();
            file.CheckNullorWithSpace();
            file.Sctructure();
            file.GetData();
            return (true, file.GetData());
        }
    }
}