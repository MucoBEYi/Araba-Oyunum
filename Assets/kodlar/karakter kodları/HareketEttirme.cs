using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HareketEttirme : MonoBehaviour
{
   private bool oyunbitti = false;
    void Start()
    {

    }

    void Update()
    {
        //sahneyi r tuşu ile sıfırlayabiliriz.
        if (Input.GetKey("r"))
        {
            oyunbitti = true;
            Invoke("gerisar", 3f);
        }
        //otomatik ileri gidiyor        
        if (oyunbitti == false)
        {
            GetComponent<Rigidbody>().transform.Translate(1f, 0, 0);
        }
        //eğer atadığımız tuşlara basarsak o yöne doğru ilerleyecektir.
        else if (oyunbitti == true)
        {
            transform.Translate(Vector3.zero);
        }
        if (oyunbitti == false)
        {
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().transform.Translate(0, 0, 1);
            }
            if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody>().transform.Translate(1, 0, 0);
            }
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().transform.Translate(0, 0, -1);
            }
        }
    }

    //sahneyi sıfırlıyor
    private void OnCollisionEnter(Collision oc)
    {
        if (oc.collider.tag == "engel")
        {
            Invoke("gerisar", 3f);
            oyunbitti = true;
        }
    }

    private void gerisar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        oyunbitti = false;
    }
}
