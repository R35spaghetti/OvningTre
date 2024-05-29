namespace ÖvningTre.Polymorfism;

public class EmailInputError : UserError
{
    public override string UEMessage()
    {
        return "You entered the incorrect email format. This fired an error!";
    }
}