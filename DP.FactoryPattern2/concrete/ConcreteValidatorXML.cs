namespace DP.FactoryPattern2.concrete;

public class ConcreteValidatorXml : Validator
{
    public override IFileValidator Create()
    {
        return new TXT();
    }
}
