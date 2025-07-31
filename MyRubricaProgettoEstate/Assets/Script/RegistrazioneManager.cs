using UnityEngine;
using TMPro;
public class RegistrazioneManager : MonoBehaviour
{
    public TMP_InputField inputNome;
    public TMP_InputField inputNumeroDiTelefono;
    public TMP_InputField inputPassword;
    public GameObject scrittaDiErrore;

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
}
