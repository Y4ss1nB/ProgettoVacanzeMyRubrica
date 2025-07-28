using UnityEngine;
using System;

public class ContattoPrivato : Contatto
{
    private string indirizzo;
    private string soprannome;

    public ContattoPrivato(string nome, string telefono, string indirizzo, string soprannome) : base(nome, telefono, TipoContatto.Privato)
    {
        this.indirizzo = indirizzo;
        this.soprannome = soprannome;
    }

    public string GetIndirizzo()
    {
        return this.indirizzo;
    }
    public string GetSoprannome()
    {
        return this.soprannome;
    }
}
