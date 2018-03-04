using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    private const string МY_FERRARI_MODEL = "488-Spider";

    public string Model => МY_FERRARI_MODEL;

    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }
}
