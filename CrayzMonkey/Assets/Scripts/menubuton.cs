using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menubuton : MonoBehaviour
{
    public Sprite[] sesdurumlari;
    int sesdurum;
    public Button sesdurumu;
    void Start()
    {
        sesdurum = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ananamenubutonlar(int a)
    {
        if (a == 0)
        {
            SceneManager.LoadScene("SampleScene");

        }
        else if (a == 1)
        {
            Application.Quit();
        }
        else if (a == 2)
        {
            sesdurum++;
            if (sesdurum % 2 == 0)
            {
                sesdurumu.GetComponent<Image>().sprite = sesdurumlari[0];
                //sp.sprite = sesdurumlari[0];
               GetComponent<AudioSource>().Pause();
            }
            else
            {
                sesdurumu.GetComponent<Image>().sprite = sesdurumlari[1];
                // sp.sprite = sesdurumlari[1];
               GetComponent<AudioSource>().Play();
            }
        }
    }

}
