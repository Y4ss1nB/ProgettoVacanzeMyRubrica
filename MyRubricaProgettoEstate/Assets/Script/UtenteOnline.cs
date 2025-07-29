using UnityEngine;

public static class UtenteOnline
{

    //attributo
    private static Utente utenteLoggato;

    //getter
    public static Utente GetUtenteLoggato()
    {
        return utenteLoggato;
    }

    //setter
    public static void SetUtenteLoggato(Utente utente)
    {
        utenteLoggato = utente;
    }
}
