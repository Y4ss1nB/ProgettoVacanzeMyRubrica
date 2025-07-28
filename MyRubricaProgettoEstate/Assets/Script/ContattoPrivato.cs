using UnityEngine;
using System;

public class ContattoPrivato : Contatto
{
    //attributi
    private string indirizzo;
    private string soprannome;

    //costruttore
    public ContattoPrivato(string nome, string telefono, string indirizzo, string soprannome) : base(nome, telefono, TipoContatto.Privato)
    {
        this.indirizzo = indirizzo;
        this.soprannome = soprannome;
    }

    //getter
    public string GetIndirizzo()
    {
        return this.indirizzo;
    }
    public string GetSoprannome()
    {
        return this.soprannome;
    }

    //setter
    public void SetIndirizzo(string indirizzo)
    {
        this.indirizzo = indirizzo;
    }
    public void SetSoprannome(string soprannome)
    {
        this.soprannome = soprannome;
    }

    public override string GetDatiUlteriori()
    {
        return " Indirizzo: " + GetIndirizzo() + " Soprannome: " + GetSoprannome();
    }

    public override string ToString()
    {
        return base.ToString() + GetDatiUlteriori();
    }
}
