public class StringChanger
{
    /// <summary>
    /// Метод для реверсирования строки
    /// </summary>
    /// <param name="userChoice">Строка для реверса</param>
    /// <returns></returns>
    public string Reverse(string userChoice)
    {
        char[] reverse = userChoice.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }
}
