using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class destroy : MonoBehaviour
{
    public int puan;                                    // Oyuncunun ald��� puan
    public int hedef;                                  // leveli ge�mesi i�in almas� gereken puan
    public int can = 3;
    public TextMeshProUGUI cansay;

    void Start()
    {
        
    }


    void Update()
    {
        cansay.text = can.ToString("f0");
    }

    void OnCollisionEnter(Collision temaseden)
    {
        if(temaseden.gameObject.tag == "mini")
        {
            Destroy(temaseden.gameObject);
            puan++;
            Debug.Log(puan);
        }
        
        if(temaseden.gameObject.tag == "toplama")
        {
            Destroy(temaseden.gameObject);
            can--;
        }

        if (puan == hedef)
        {
            SceneManager.LoadScene("Level2");
        }

    }

}
