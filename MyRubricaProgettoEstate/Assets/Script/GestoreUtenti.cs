using UnityEngine;
using System.Collections.Generic;
public static class GestoreUtenti
{
    private static List<Utente> utenti = new List<Utente>();

    public static List<Utente> GetUtenti()
    {
        return utenti;
    }
    
    public static bool RegistraUtente(string telefono, string password, string nomeUtente)
    {
        foreach (Utente utente in utenti)
        {
            if (utente.GetTelefono() == telefono)
            {
                return false;
            }
        }
        Utente utenteDaAggiungere = new Utente(telefono, password, nomeUtente);
        utenti.Add(utenteDaAggiungere);
        return true;
    }

    public static Utente LoginUtente(string telefono, string password)
    {
        foreach (Utente utente in utenti)
        {
            if (utente.GetTelefono() == telefono && utente.GetPassword() == password)
            {
                return utente;
            }
        }

        return null;
    }
    
}
