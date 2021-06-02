using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombalar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * -250);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {

            Destroy(gameObject);

        }
        else if (collision.gameObject.tag == "anakarakter")
        {
            GetComponent<Animator>().Play("bomba");
            Invoke("yoket", 0.3f);
        }

    }
    void yoket()
    {
        Destroy(gameObject);
    }



}
