using UnityEngine;
using UnityEngine.UI;

public class MaymunKontrol : MonoBehaviour
{
    public static int  skor = 0;
    public static int can;
    public Text s;
    Animator a;
    AudioSource karaktersesleri;
    public AudioClip hasaryeme;
    public AudioClip meyveyemesesi;
    public GameObject hasaralma;
    public GameObject[] canlar;
    public GameObject oyunmuzigi;
    public AudioClip gameoversesi;
    public static bool gamestop;
    public static bool gameOver;
   int topskor;
    void Start()
    {
        topskor = PlayerPrefs.GetInt("topskor");
        Time.timeScale = 1;
        a = GetComponent<Animator>();
        can = 2;
        skor = 0;
        karaktersesleri = GetComponent<AudioSource>();
        gamestop = false;
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        karakterHareket();
        s.text = "" + skor;
    }
    void karakterHareket()
    {
        if (Input.GetKey(KeyCode.A) && gamestop == false)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(Vector3.left * Time.deltaTime*8);
            a.Play("run");
        }
        else if (Input.GetKey(KeyCode.D) && gamestop==false)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector3.right * Time.deltaTime*8);

            a.Play("run");

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meyve")
        {
            skor += 20;
         

            karaktersesleri.PlayOneShot(meyveyemesesi);
            Destroy(collision.gameObject);
        
        }
        else if (collision.gameObject.tag == "bomba")
        {
            hasaralma.SetActive(true);
            Invoke("hasarKapat", 0.3f);
            karaktersesleri.PlayOneShot(hasaryeme);
            canlar[can].GetComponent<Animator>().Play("canazalma");
            Invoke("cansil",0.55f);
        }
    }
    void cansil()
    {
        
        canlar[can].SetActive(false);
        can--;
        if (can == -1)
        {
            hasaralma.SetActive(true);
            gamestop = true;
            gameOver = true;
            if (topskor < skor)
            {
                topskor = skor;
                PlayerPrefs.SetInt("topskor", topskor);
            }
            oyunmuzigi.GetComponent<AudioSource>().Pause();
            karaktersesleri.PlayOneShot(gameoversesi);
            Time.timeScale = 0;

        }
    }
    
    void hasarKapat()
    {
        hasaralma.SetActive(false);
    }
  
}
