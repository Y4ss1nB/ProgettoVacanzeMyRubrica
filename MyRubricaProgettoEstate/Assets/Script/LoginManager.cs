using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    //attributi
    public TMP_InputField inputNumeroDiTelefono;
    public TMP_InputField inputPassword;
    public GameObject scrittaDiErrore;

    public void Start()
    {
        this.scrittaDiErrore.SetActive(false);
        this.SvuotaCampi();
    }

    //getter
    public string GetInputNumeroDiTelefono()
    {
        return this.inputNumeroDiTelefono.text;
    }

    public string GetInputPassword()
    {
        return this.inputPassword.text;
    }

    public void Login()
    {
        this.scrittaDiErrore.SetActive(false);

        try
        {
            Utente utente = GestoreUtenti.LoginUtente(this.GetInputNumeroDiTelefono(), this.GetInputPassword());

            if (utente == null)
            {
                throw new ErroreException();
            }

            UtenteOnline.SetUtenteLoggato(utente);
            SystemManager.instance.MostraProfilo(utente);
        }
        catch (ErroreException)
        {
            this.scrittaDiErrore.SetActive(true);

        }

        this.SvuotaCampi();
    }

    public void SvuotaCampi()
    {
        this.inputNumeroDiTelefono.text = "";
        this.inputPassword.text = "";
    }
}
