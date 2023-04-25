namespace DP.FactoryPattern2.concrete;

public class ConcreteValidatorTxt : Validator
{
    public override IFileValidator Create()
    {
        return new XML();
    }
}
