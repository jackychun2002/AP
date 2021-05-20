namespace T2008M.Labs1
{
    public class Fashion:Product

    {
    public string color;
    public string size;

    public bool CheckcolorAndsize(string c, string s)
    {
        if (color.Equals(c) && size.Equals(s) && qty > 0)
            return true;
        return false;
    }
    }
}