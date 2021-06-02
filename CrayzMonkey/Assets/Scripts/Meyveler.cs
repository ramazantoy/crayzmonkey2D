using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meyveler : MonoBehaviour
{
    AudioSource ses;
    public AudioClip dusmesesi;
    
    void Start()
    {
        ses = GetComponent<AudioSource>();
        
    }

 
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * -250);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {

            ses.PlayOneShot(dusmesesi);
            GetComponent<SpriteRenderer>().sprite = null;
            GetComponent<Collider2D>().isTrigger = true;
            MaymunKontrol.skor -=10;//Meyve yere düşer ise skorun 10 azaltılması;
            Invoke("yoket",0.3f);
        }
        
    }
    void yoket()
    {
        Destroy(gameObject);
    }
}
