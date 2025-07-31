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
}
