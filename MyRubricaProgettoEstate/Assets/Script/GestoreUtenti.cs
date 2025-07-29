using UnityEngine;
using System.Collections.Generic;
public static class GestoreUtenti
{
    private static List<Utente> utenti = new List<Utente>();

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
}
