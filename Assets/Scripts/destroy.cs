using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    public int puan;                                    // Oyuncunun ald��� puan
    public int hedef;                                  // leveli ge�mesi i�in almas� gereken puan
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision temaseden)
    {
        if(temaseden.gameObject.tag == "mini")
        {
            Destroy(temaseden.gameObject);
            puan++;
            Debug.Log(puan);
        }

        //if (puan == hedef)                            Level 2 tasarland���nda a��lacak.
        //{
        //    SceneManager.LoadScene("level2");
        //}

    }

}
