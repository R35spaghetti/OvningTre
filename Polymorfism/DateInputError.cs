namespace ÖvningTre.Polymorfism;

public class DateInputError : UserError
{
    public override string UEMessage()
    {
        return "You entered the incorrect date format, use the following date format: DD-MM-YYYY";
    }
}