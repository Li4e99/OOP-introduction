public class ACoder : IСoder

{
    private readonly char[] _InputCharArray;


    public ACoder(string inputString)
    {
        _InputCharArray = inputString.ToCharArray();
    }

    public string Decode()
    {
        for (int i = 0; i < _InputCharArray.Length; i++)
        {
            _InputCharArray[i] = (char)(_InputCharArray[i] - 1);
        }

        return GetString();
    }

    public string Encode()
    {
        for (int i = 0; i < _InputCharArray.Length; i++)
        {
            _InputCharArray[i] = (char)(_InputCharArray[i] + 1);
        }

       return GetString();
    }

    public string GetString()
    {
        return string.Concat(_InputCharArray);
    }
}

