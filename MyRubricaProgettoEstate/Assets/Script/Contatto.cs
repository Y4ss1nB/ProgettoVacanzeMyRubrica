using UnityEngine;
using System;
public abstract class Contatto
{
    //attributi
    private string nome;
    private string telefono;
    private TipoContatto categoria;


    //costruttore
    public Contatto(string nome, string telefono, TipoContatto categoria)
    {
        this.nome = nome;
        this.telefono = telefono;
        this.categoria = categoria;
    }

    //getter
    public string GetNome()
    {
        return this.nome;
    }
    public string GetTelefono()
    {
        return this.telefono;
    }
    public TipoContatto GetCategoria()
    {
        return this.categoria;
    }

    //setter
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetTelefono(string telefono)
    {
        this.telefono = telefono;
    }
    public void SetCategoria(TipoContatto categoria)
    {
        this.categoria = categoria;
    }

    public abstract string GetDatiUlteriori();

    public override string ToString()
    {
        return "\nCategoria: " + GetCategoria() + " Nome: " + GetNome() + " Telefono: " + GetTelefono();
    }
}
