using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    int s;
    void Start()
    {
        s = -7;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        s = (s + 1) % 21;
        collision.gameObject.transform.position = new Vector3(s + -7, 10+s, 1);
    }
}
