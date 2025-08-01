using UnityEngine;
using TMPro;

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
    public static SystemManager instance;
    public TMP_Text nomeUtenteProfilo;

    public void Awake()
    {
        instance = this;
        MostraLogin();
    }

    public void MostraLogin()
    {
        UtenteOnline.SetUtenteLoggato(null);
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

    public void MostraProfilo(Utente utente)
    {
        panelloLogin.SetActive(false);
        panelloRegistrazione.SetActive(false);
        panelloProfilo.SetActive(true);
        panelloRubrica.SetActive(false);
        panelloAggiuntaContattoPrivato.SetActive(false);
        panelloAggiuntaContattoLavorativo.SetActive(false);
        panelloEliminazioneContatto.SetActive(false);
        panelloRicercaContatto.SetActive(false);

        nomeUtenteProfilo.text = utente.GetNomeUtente();
    }

    public void MostraProfiloTatsoIndietro()
    {
        Utente utente = UtenteOnline.GetUtenteLoggato();
        this.MostraProfilo(utente);
    }

    public void MostraRubrica()
    {
        panelloLogin.SetActive(false);
        panelloRegistrazione.SetActive(false);
        panelloProfilo.SetActive(false);
        panelloRubrica.SetActive(true);
        panelloAggiuntaContattoPrivato.SetActive(false);
        panelloAggiuntaContattoLavorativo.SetActive(false);
        panelloEliminazioneContatto.SetActive(false);
        panelloRicercaContatto.SetActive(false);
    }

    public void MostraAggiuntaContattoPrivato()
    {
        panelloRubrica.SetActive(false);
        panelloAggiuntaContattoPrivato.SetActive(true);
    }

    public void MostraAggiuntaContattoLavorativo()
    {
        panelloRubrica.SetActive(false);
        panelloAggiuntaContattoLavorativo.SetActive(true);
    }

    public void MostraEliminazioneContatto()
    {
        panelloRubrica.SetActive(false);
        panelloEliminazioneContatto.SetActive(true);
    }

    public void MostraRicercaContatto()
    {
        panelloRubrica.SetActive(false);
        panelloRicercaContatto.SetActive(true);
    }
}
