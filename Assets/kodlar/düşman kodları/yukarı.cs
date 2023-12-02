using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukarı : MonoBehaviour
{
    public float hiz = 2f;
    public Vector3 orijinal_konum;
    public Vector3 gittigi_konum;
    public Vector3 gittigi_konum2;
    public Transform mevcut_konum;
    public GameObject platformum;
    void Start()
    {
        orijinal_konum = platformum.transform.position;
    }


    void Update()
    {
        platformum.transform.position = Vector3.MoveTowards(platformum.transform.position, orijinal_konum, Time.deltaTime * hiz);
        if (platformum.transform.position == orijinal_konum)
        {
            orijinal_konum = gittigi_konum;

            if (orijinal_konum == gittigi_konum)
            {
                gittigi_konum = gittigi_konum2;
                if( gittigi_konum == gittigi_konum2)
                {
                    gittigi_konum2 = platformum.transform.position;
                }
            }
        }

    }
}
