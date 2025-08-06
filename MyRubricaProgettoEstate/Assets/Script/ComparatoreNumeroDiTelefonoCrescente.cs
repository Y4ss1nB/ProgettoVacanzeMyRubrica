using UnityEngine;
using System;
using System.Collections.Generic;

public class ComparatoreOrdineAlfabeticoNomeContatto : IComparer<Contatto>
{
    public ComparatoreOrdineAlfabeticoNomeContatto()
    {

    }

    public int Compare(Contatto contattoUno, Contatto contattoDue)
    {
        return contattoUno.GetNome().CompareTo(contattoDue.GetNome());
    }
}
