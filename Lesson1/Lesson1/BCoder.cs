public class BCoder : IСoder

{
    private readonly char[] _InputCharArray;


    public BCoder(string inputString)
    {
        _InputCharArray = inputString.ToCharArray();
    }

    public string Decode()
    {

        int step = 4;
        for (int i = 0; i < _InputCharArray.Length; i++)
        {
            _InputCharArray[i] = (char)(_InputCharArray[i] + step);
        }

        return GetString();
    }

    public string Encode()
    {
        int step = 4;
        for (int i = 0; i < _InputCharArray.Length; i++)
        {

            _InputCharArray[i] = (char)(_InputCharArray[i] + step);

        }

        return GetString();
    }

    public string GetString()
    {
        return string.Concat(_InputCharArray);
    }
}

