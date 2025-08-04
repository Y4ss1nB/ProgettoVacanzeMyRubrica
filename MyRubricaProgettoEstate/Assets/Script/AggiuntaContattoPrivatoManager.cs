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
}
