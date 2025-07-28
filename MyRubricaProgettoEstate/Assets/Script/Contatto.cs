using UnityEngine;
using System;
public class Contatto
{
    private string nome;
    private string telefono;
    private TipoContatto categoria;


    public Contatto(string nome, string telefono, TipoContatto categoria)
    {
        this.nome = nome;
        this.telefono = telefono;
        this.categoria = categoria;
    }

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
}
