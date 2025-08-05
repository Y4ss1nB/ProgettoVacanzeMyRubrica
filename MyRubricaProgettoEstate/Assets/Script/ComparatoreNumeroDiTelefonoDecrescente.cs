using UnityEngine;
using System;
using System.Collections.Generic;

public class ComparatoreNumeroDiTelefonoDecrescente : IComparer<Contatto>
{
    public ComparatoreNumeroDiTelefonoDecrescente()
    {

    }
    
    public int Compare(Contatto contattoUno, Contatto contattoDue)
    {
        return contattoDue.GetTelefono().CompareTo(contattoUno.GetTelefono());
    }
}
