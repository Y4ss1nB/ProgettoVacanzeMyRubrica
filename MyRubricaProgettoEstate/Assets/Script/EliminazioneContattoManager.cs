using UnityEngine;
using System;
using TMPro;

public class EliminazioneContattoManager : MonoBehaviour
{
    public TMP_InputField inputNumero;
    public GameObject scrittaDiErrore;

    public void Start()
    {
        this.scrittaDiErrore.SetActive(false);
        this.SvuotaCampi();
    }
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
            }else
            {
                this.TornaAllaRubrica();
            }
        }
        catch (ErroreException)
        {
            this.scrittaDiErrore.SetActive(true);

        }
    }

    public void TornaAllaRubrica()
    {
        this.scrittaDiErrore.SetActive(false);
        SystemManager.instance.MostraRubrica();
        SvuotaCampi();
    }
    public void SvuotaCampi()
    {
        this.inputNumero.text = "";
    }
}
