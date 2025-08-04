using UnityEngine;
using System;
using TMPro;

public class RicercaContattoManager : MonoBehaviour
{
    public TMP_InputField inputNome;
    public GameObject scrittaDiErrore;
    public TMP_Text InformazioniContatto;

    public void Start()
    {
        this.scrittaDiErrore.SetActive(false);
        this.SvuotaCampi();
    }

    public string GetinputNome()
    {
        return this.inputNome.text;
    }

    public void Cerca()
    {
        try
        {
            if (this.GetinputNome() == "")
            {
                throw new ErroreException();
            }

            Utente utente = UtenteOnline.GetUtenteLoggato();

            foreach (Contatto contatto in utente.GetContatti())
            {
                if (contatto.GetNome() == this.GetinputNome())
                {
                    this.scrittaDiErrore.SetActive(false);
                    this.InformazioniContatto.text = contatto.ToString();
                    return;
                }
            }
            throw new ErroreException();
        }
        catch (ErroreException)
        {
            this.SvuotaCampi();
            this.scrittaDiErrore.SetActive(true);

        }
    }

    public void TornaAllaRubrica()
    {
        this.scrittaDiErrore.SetActive(false);
        SystemManager.instance.MostraRubrica();
        this.SvuotaCampi();
    }
    public void SvuotaCampi()
    {
        this.inputNome.text = "";
        this.InformazioniContatto.text = "";
    }
}
