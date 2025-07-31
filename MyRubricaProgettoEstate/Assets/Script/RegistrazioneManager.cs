using UnityEngine;
using TMPro;
public class RegistrazioneManager : MonoBehaviour
{
    public TMP_InputField inputNome;
    public TMP_InputField inputNumeroDiTelefono;
    public TMP_InputField inputPassword;
    public GameObject scrittaDiErrore;

    public void Start()
    {
        this.scrittaDiErrore.SetActive(false);
        this.SvuotaCampi();
    }

    public string GetInputNome()
    {
        return this.inputNome.text;
    }
    public string GetInputNumeroDiTelefono()
    {
        return this.inputNumeroDiTelefono.text;
    }
    public string GetInputPassword()
    {
        return this.inputPassword.text;
    }

    public void Registrazione()
    {
        this.scrittaDiErrore.SetActive(false);

        try
        {
            if (this.GetInputNome() == "" || this.GetInputNumeroDiTelefono() == "" || this.GetInputPassword() == "")
            {
                throw new ErroreException();
            }

            bool isStatoRegistrato = GestoreUtenti.RegistraUtente(this.GetInputNumeroDiTelefono(), this.GetInputPassword(), this.GetInputNome());
            if (!isStatoRegistrato)
            {
                throw new ErroreException();
            }
            else
            {
                SystemManager.instance.MostraLogin();
            }
        }
        catch (ErroreException)
        {
            this.scrittaDiErrore.SetActive(true);
        }
        this.SvuotaCampi();
    }

    public void SvuotaCampi()
    {
        this.inputNome.text = "";
        this.inputNumeroDiTelefono.text = "";
        this.inputPassword.text = "";
    }
}
