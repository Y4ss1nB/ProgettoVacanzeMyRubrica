using UnityEngine;
using System;
using System.Collections.Generic;

public class Utente
{
    private string telefono;
    private string password;
    private string nomeUtente;
    private List<Contatto> listaContatti;

    public Utente(string telefono, string password, string nomeUtente)
    {
        this.telefono = telefono;
        this.password = password;
        this.nomeUtente = nomeUtente;
        this.listaContatti = new List<Contatto>();
    }

    public string GetTelefono()
    {
        return this.telefono;
    }
    public string GetPassword()
    {
        return this.password;
    }
    public string GetNomeUtente()
    {
        return this.nomeUtente;
    }
    public List<Contatto> GetContatti()
    {
        return this.listaContatti;
    }

    public void SetTelfono(string telefono)
    {
        this.telefono = telefono;
    }
    public void SetPassword(string password)
    {
        this.password = password;
    }
    public void SetNomeUtente(string nomeUtente)
    {
        this.nomeUtente = nomeUtente;
    }

    public void AggiungiContatto(Contatto contatto)
    {
        this.listaContatti.Add(contatto);
    }

    public bool RimuoviContatto(string numeroDaCancellare)
    {
        foreach (Contatto contatto in listaContatti)
        {
            if (contatto.GetTelefono() == numeroDaCancellare)
            {
                this.listaContatti.Remove(contatto);
                return true;
            }
        }
        return false;
    }

    public override string ToString()
    {
        return "\nNumero: " + GetTelefono() + " Nome: " + GetNomeUtente();
    }
}
