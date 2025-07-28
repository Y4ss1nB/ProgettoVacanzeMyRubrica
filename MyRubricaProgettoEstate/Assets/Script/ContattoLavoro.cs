using UnityEngine;
using System;

public class ContattoLavoro : Contatto
{
    private string nomeAzienda;
    private string emailAziendale;

    public ContattoLavoro(string nome, string telefono, string nomeAzienda, string emailAziendale) : base(nome, telefono, TipoContatto.Lavoro)
    {
        this.nomeAzienda = nomeAzienda;
        this.emailAziendale = emailAziendale;
    }
}
