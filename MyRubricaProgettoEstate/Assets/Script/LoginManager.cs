using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField inputNumeroDiTelefono;
    public TMP_InputField inputPassword;
    public GameObject scrittaDiErrore;

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

    }
}
