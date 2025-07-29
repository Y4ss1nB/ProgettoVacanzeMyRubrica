using UnityEngine;

public static class UtenteOnline
{
    private static Utente utenteLoggato;

    public static Utente GetUtenteLoggato()
    {
        return this.utenteLoggato;
    }

    public static void SetUtenteLoggato(Utente utente)
    {
        this.utenteLoggato = utente;
    }
}
