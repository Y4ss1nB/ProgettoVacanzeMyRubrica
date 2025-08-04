using UnityEngine;
using System;
using TMPro;

public class RicercaContattoManager : MonoBehaviour
{
    public TMP_InputField inputNome;
    public GameObject scrittaDiErrore;
    public TMP_Text InformazioniContatto;

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
                    this.InformazioniContatto.text = contatto.ToString();
                    return;
                }
            }
            throw new ErroreException();
        }
        catch (ErroreException)
        {
            this.scrittaDiErrore.SetActive(true);

        }
    }
}
