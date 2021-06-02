using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeyveKontrol : MonoBehaviour
{
    public GameObject[] Meyveler;
    public GameObject[] Bombalar;
    public Vector3[] meyvekonumlari;


    void Start()
    {
        InvokeRepeating("meyveUret", 3f, 4f);
        
    }
    void Update()
    {
        
    }

    [System.Obsolete]
    void meyveUret()
    {
        Vector3 konum;
        GameObject meyve;

        int yuzde = Random.RandomRange(0, 100);
        int indis = Random.RandomRange(0, 5);
        if (yuzde <=70)
        {
            konum = meyvekonumlari[indis];
            indis = Random.RandomRange(0, 5);
            meyve = Meyveler[indis];
            Instantiate(meyve, konum, Quaternion.identity);
        }
        else
        {
            Invoke("bombayolla", 0.5f);
            Invoke("bombayolla", 1f);
            Invoke("bombayolla", 1.5f);
        }
      
    }

    [System.Obsolete]
    void bombayolla()
    {
        GameObject bomba;
        int yuzde = Random.RandomRange(0, 100);
        int indis = Random.RandomRange(0, 5);
        Vector3 konum;
        konum = meyvekonumlari[indis];
        indis = Random.RandomRange(0, 5);
        bomba = Bombalar[indis];
        Instantiate(bomba, konum, Quaternion.identity);
    }

}

