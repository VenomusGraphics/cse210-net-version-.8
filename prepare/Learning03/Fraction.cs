using System.Globalization;

public class Fraction
{

private int _Top;
private int _Bottom;

public Fraction()
{
    _Top = 1;

    _Bottom = 1;

    
}
public Fraction(int wholeNumber)
{
     _Top = wholeNumber;

     _Bottom = 1;
}

public Fraction(int top, int bottom)
{
    _Top = top;
    _Bottom = bottom;
}
public string Getfration(int top, int bottom)
{
    string FrationText = $"{_Top}/{_Bottom}";
    
    return FrationText;
}
public double GetValue()
{
    // legit could not figure out so i looked at soulution
    return (double)_Top/(double)_Bottom;
}

}