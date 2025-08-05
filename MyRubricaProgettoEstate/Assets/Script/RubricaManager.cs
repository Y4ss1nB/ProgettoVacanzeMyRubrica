using UnityEngine;
using TMPro;
using System.Collections.Generic;


public class RubricaManager : MonoBehaviour
{
    public TMP_Text zonaInformazioniContatti;
    public Utente utente;
    public static RubricaManager instance;

    IComparer<Contatto> comparatoreNumeroDiTelefonoCrescente;
    IComparer<Contatto> comparatoreNumeroDiTelefonoDecrescente;

    public void Awake()
    {
        instance = this;
        this.comparatoreNumeroDiTelefonoCrescente = new ComparatoreNumeroDiTelefonoCrescente();
        this.comparatoreNumeroDiTelefonoDecrescente = new ComparatoreNumeroDiTelefonoDecrescente();
    }

    public void MostraInformazioniContatti()
    {
        this.utente = UtenteOnline.GetUtenteLoggato();
        if (this.utente == null)
        {
            return;
        }

        this.zonaInformazioniContatti.text = "";
        List<Contatto> contatti = this.utente.GetContatti();
        foreach (Contatto contatto in contatti)
        {
            this.zonaInformazioniContatti.text += contatto.ToString();
        }

        if (contatti.Count == 0)
        {
            this.zonaInformazioniContatti.text = "Non ci sono ancora contatti...";
        }
    }

}
