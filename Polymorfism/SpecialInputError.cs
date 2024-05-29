namespace ÖvningTre.Polymorfism;

public class SpecialInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use one or several special characters in a text only field. This fired an error!";
    }
}