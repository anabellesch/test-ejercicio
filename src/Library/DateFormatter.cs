namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (!Separadores (date))
        {
            return string.Empty;
        }
        if (String.IsNullOrEmpty(date))
        {
            return string.Empty;
        }
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
       
       
        
        
    }
    private static bool Separadores(string date)

    {
        return date [2] == '/' && date [5]=='/';
    }
}

