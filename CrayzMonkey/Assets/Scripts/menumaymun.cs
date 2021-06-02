using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menumaymun : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        hareketAnim();
    }
    void hareketAnim()
    {
        transform.Translate( Vector3.right * Time.deltaTime * 5);
        if (gameObject.transform.position.x >= 11f)
        {
            gameObject.transform.position = new Vector3(-13f,0,0);
        }


    }
}
