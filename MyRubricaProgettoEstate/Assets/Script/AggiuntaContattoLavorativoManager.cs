using UnityEngine;
using System;
using TMPro;

public class AggiuntaContattoLavorativoManager : MonoBehaviour
{

    //attributi
    public TMP_InputField inputNomeContatto;
    public TMP_InputField inputNumeroContatto;
    public TMP_InputField inputEmailAziendaleContatto;
    public TMP_InputField inputNomeAziendaContatto;
    public GameObject scrittaDiErrore;

    public void Start()
    {
        this.scrittaDiErrore.SetActive(false);
        this.SvuotaCampi();
    }

    //getter
    public string GetInputNomeContatto()
    {
        return this.inputNomeContatto.text;
    }
    public string GetInputNumeroContatto()
    {
        return this.inputNumeroContatto.text;
    }
    public string GetInputEmailAziendaleContatto()
    {
        return this.inputEmailAziendaleContatto.text;
    }
    public string GetInputNomeAziendaContatto()
    {
        return this.inputNomeAziendaContatto.text;
    }

    public void Aggiungi()
    {
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

            ContattoLavoro contattoLavorativoDaAggiungere = new ContattoLavoro(this.GetInputNomeContatto(), this.GetInputNumeroContatto(), this.GetInputNomeAziendaContatto(), this.GetInputEmailAziendaleContatto());
            utente.AggiungiContatto(contattoLavorativoDaAggiungere);
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
        this.inputEmailAziendaleContatto.text = "";
        this.inputNomeAziendaContatto.text = "";
    }

}
