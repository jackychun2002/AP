namespace T2008M.Labs1
{
    public class Diamon : Product
    {
        public int care;

        public bool Checkauth()
        {
            if (care > 10)
                return true;
            return false;
        }
    }
}