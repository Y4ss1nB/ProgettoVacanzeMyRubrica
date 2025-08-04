using UnityEngine;
using System;
using TMPro;

public class AggiuntaContattoLavorativoManager : MonoBehaviour
{
    public TMP_InputField inputNomeContatto;
    public TMP_InputField inputNumeroContatto;
    public TMP_InputField inputEmailAziendaleContatto;
    public TMP_InputField inputNomeAziendaContatto;
    public GameObject scrittaDiErrore;

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

}
