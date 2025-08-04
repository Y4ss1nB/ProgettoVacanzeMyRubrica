using UnityEngine;
using System;
using TMPro;

public class EliminazioneContattoManager : MonoBehaviour
{
    public TMP_InputField inputNumero;
    public GameObject scrittaDiErrore;

    public string GetInputNumero()
    {
        return this.inputNumero.text;
    }

    public void Elimina()
    {
        try
        {
            if (this.GetInputNumero() == "")
            {
                throw new ErroreException();
            }

            Utente utente = UtenteOnline.GetUtenteLoggato();

            bool isContattoStatoRimosso = utente.RimuoviContatto(this.GetInputNumero());
            if (!isContattoStatoRimosso)
            {
                throw new ErroreException();
            }
        }
        catch (ErroreException)
        {
            this.scrittaDiErrore.SetActive(true);

        }
    }
}
