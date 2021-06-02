using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButonEtkilesimler : MonoBehaviour
{
    public GameObject[] oyunbitisbutonları;
    int sesdurum;
    public Sprite[] sesdurumlari;
    public Button sesdurumu;
    public Button pausedurumu;
    public GameObject arkaplansesi;
    int pausedurum;
    public Sprite [] pausedurumlari;
    public Text t;

    void Start()
    {
        sesdurum = -1;
        pausedurum = 0;
    }
    void Update()
    {
        if (MaymunKontrol.gameOver == true)
        {
            oyunBitis();
        }
    }
    public void ButonEtklesimi(int butonno)
    {
        if (butonno == 0)
        {
            sesdurum++;
            if (sesdurum % 2 == 0)
            {
                sesdurumu.GetComponent<Image>().sprite = sesdurumlari[0];
                //sp.sprite = sesdurumlari[0];
                arkaplansesi.GetComponent<AudioSource>().Pause();
            }
            else
            {
                sesdurumu.GetComponent<Image>().sprite = sesdurumlari[1];
                // sp.sprite = sesdurumlari[1];
                arkaplansesi.GetComponent<AudioSource>().Play();
            }
        }
        else if (butonno == 1)
        {
            pausedurum++;
            if (pausedurum % 2 == 0)
            {
                pausedurumu.GetComponent<Image>().sprite = pausedurumlari[0];
                //sp.sprite = sesdurumlari[0];
                Time.timeScale = 0;
                MaymunKontrol.gamestop = true;
               
            }
            else
            {
                pausedurumu.GetComponent<Image>().sprite =pausedurumlari[1];
                // sp.sprite = sesdurumlari[1];
                arkaplansesi.GetComponent<AudioSource>().Play();
                Time.timeScale = 1;
                MaymunKontrol.gamestop = false;
            }
        }
        else if (butonno == 2)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (butonno == 3)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("anamenu");
        }
    }
   void oyunBitis()
    {
        sesdurumu.gameObject.SetActive(false);
        pausedurumu.gameObject.SetActive(false);

        for (int i = 0; i < 6; i++)
        {
            oyunbitisbutonları[i].SetActive(true);
        }
        t.text = "" + PlayerPrefs.GetInt("topskor");
    }
}
