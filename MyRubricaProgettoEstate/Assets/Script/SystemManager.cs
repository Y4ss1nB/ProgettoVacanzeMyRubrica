using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public GameObject panelloLogin;
    public GameObject panelloRegistrazione;
    public GameObject panelloProfilo;
    public GameObject panelloRubrica;
    public GameObject panelloAggiuntaContattoPrivato;
    public GameObject panelloAggiuntaContattoLavorativo;
    public GameObject panelloEliminazioneContatto;
    public GameObject panelloRicercaContatto;

    public void MostraLogin()
    {
        panelloLogin.SetActive(true);
        panelloRegistrazione.SetActive(false);
        panelloProfilo.SetActive(false);
        panelloRubrica.SetActive(false);
        panelloAggiuntaContattoPrivato.SetActive(false);
        panelloAggiuntaContattoLavorativo.SetActive(false);
        panelloEliminazioneContatto.SetActive(false);
        panelloRicercaContatto.SetActive(false);
    }

    public void MostraRegistrazione()
    {
        panelloLogin.SetActive(false);
        panelloRegistrazione.SetActive(true);
        panelloProfilo.SetActive(false);
        panelloRubrica.SetActive(false);
        panelloAggiuntaContattoPrivato.SetActive(false);
        panelloAggiuntaContattoLavorativo.SetActive(false);
        panelloEliminazioneContatto.SetActive(false);
        panelloRicercaContatto.SetActive(false);
    }
}
