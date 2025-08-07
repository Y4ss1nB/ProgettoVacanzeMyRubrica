using UnityEngine;
using System;

public class ContattoLavoro : Contatto
{

    //attributi
    private string nomeAzienda;
    private string emailAziendale;

    //costruttore
    public ContattoLavoro(string nome, string telefono, string nomeAzienda, string emailAziendale) : base(nome, telefono, TipoContatto.Lavoro)
    {
        this.nomeAzienda = nomeAzienda;
        this.emailAziendale = emailAziendale;
    }

    //getter
    public string GetNomeAzienda()
    {
        return this.nomeAzienda;
    }
    public string GetEmailAziendale()
    {
        return this.emailAziendale;
    }

    //setter
    public void SetNomeAzienda(string nomeAzienda)
    {
        this.nomeAzienda = nomeAzienda;
    }
    public void SetEmailAziendale(string emailAziendale)
    {
        this.emailAziendale = emailAziendale;
    }

    public override string GetDatiUlteriori()
    {
        return " Nome Azienda: " + GetNomeAzienda() + " Email: " + GetEmailAziendale();
    }

    public override string ToString()
    {
        return base.ToString() + GetDatiUlteriori();
    }
}
