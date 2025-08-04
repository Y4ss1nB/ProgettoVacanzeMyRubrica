using UnityEngine;
using System;
using TMPro;

public class AggiuntaContattoPrivatoManager : MonoBehaviour
{
    public TMP_InputField inputNomeContatto;
    public TMP_InputField inputNumeroContatto;
    public TMP_InputField inputIndirizzoContatto;
    public TMP_InputField inputSoprannomeContatto;
    public GameObject scrittaDiErrore;

    public string GetInputNomeContatto()
    {
        return this.inputNomeContatto.text;
    }
    public string GetInputNumeroContatto()
    {
        return this.inputNumeroContatto.text;
    }
    public string GetInputIndirizzoContatto()
    {
        return this.inputIndirizzoContatto.text;
    }
    public string GetInputSoprannomeContatto()
    {
        return this.inputSoprannomeContatto.text;
    }

    public void Aggiungi()
    {
        this.scrittaDiErrore.SetActive(false);
        try
        {
            if (this.GetInputNomeContatto() == "" || this.GetInputNumeroContatto() == "")
            {
                throw new ErroreException();
            }

            Utente utente = UtenteOnline.GetUtenteLoggato();

            foreach (Contatto contatto in utente.GetContatti())
            {
                if (contatto.GetTelefono() == this.GetInputNumeroContatto() || contatto.GetNome() == this.GetInputNomeContatto())
                {
                    throw new ErroreException();
                }
            }

            ContattoPrivato contattoPrivatoDaAggiungere = new ContattoPrivato(this.GetInputNomeContatto(), this.GetInputNumeroContatto(), this.GetInputIndirizzoContatto(), this.GetInputSoprannomeContatto());
            utente.AggiungiContatto(contattoPrivatoDaAggiungere);
            this.TornaAllaRubrica();
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
        this.inputNomeContatto.text = "";
        this.inputNumeroContatto.text = "";
        this.inputIndirizzoContatto.text = "";
        this.inputSoprannomeContatto.text = "";
    }
}
