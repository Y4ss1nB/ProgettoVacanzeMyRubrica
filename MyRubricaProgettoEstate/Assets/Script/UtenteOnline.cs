using UnityEngine;

public static class UtenteOnline
{
    private static Utente utenteLoggato;

    public static Utente GetUtenteLoggato()
    {
        return utenteLoggato;
    }

    public static void SetUtenteLoggato(Utente utente)
    {
        utenteLoggato = utente;
    }
}
