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
}
