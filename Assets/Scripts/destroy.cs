using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    public int puan;                                    // Oyuncunun aldýðý puan
    public int hedef;                                  // leveli geçmesi için almasý gereken puan
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

        //if (puan == hedef)                            Level 2 tasarlandýðýnda açýlacak.
        //{
        //    SceneManager.LoadScene("level2");
        //}

    }

}
