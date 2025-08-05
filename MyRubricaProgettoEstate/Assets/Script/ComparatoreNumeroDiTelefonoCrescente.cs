using UnityEngine;
using System;
using System.Collections.Generic;

public class ComparatoreNumeroDiTelefonoCrescente : IComparer<Contatto>
{
    public ComparatoreNumeroDiTelefonoCrescente()
    {

    }

    public int Compare(Contatto contattoUno, Contatto contattoDue)
    {
        return contattoUno.GetTelefono().CompareTo(contattoDue.GetTelefono());
    }
}
