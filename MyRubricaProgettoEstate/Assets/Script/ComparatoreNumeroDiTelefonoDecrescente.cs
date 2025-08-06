using UnityEngine;
using System;
using System.Collections.Generic;

public class ComparatoreOrdineAlfabeticoContrarioNomeContatto : IComparer<Contatto>
{
    public ComparatoreOrdineAlfabeticoContrarioNomeContatto()
    {

    }
    
    public int Compare(Contatto contattoUno, Contatto contattoDue)
    {
        return contattoDue.GetNome().CompareTo(contattoUno.GetNome());
    }
}
