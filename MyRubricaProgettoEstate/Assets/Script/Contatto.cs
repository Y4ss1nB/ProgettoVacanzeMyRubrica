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
}
