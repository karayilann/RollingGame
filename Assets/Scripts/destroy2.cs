using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class destroy2 : MonoBehaviour
{
    public int puan;                                    // Oyuncunun aldýðý puan
    public int hedef;                                  // leveli geçmesi için almasý gereken puan
    public int can = 3;
    public TextMeshProUGUI cansay;
    public TextMeshProUGUI puansay;
    public GameObject losepanel;
    public GameObject karakter;
    public GameObject canpan;
    public GameObject winpanel;
    public GameObject puanpan;
    void Start()
    {

    }


    void Update()
    {
        cansay.text = "Kalan Can : " + can;
        puansay.text = "Puanýn : " + puan;
    }

    void OnCollisionEnter(Collision temaseden)
    {
        if (temaseden.gameObject.tag == "mini")
        {
            Destroy(temaseden.gameObject);
            puan++;
            Debug.Log(puan);
        }

        if (temaseden.gameObject.tag == "toplama")
        {
            Destroy(temaseden.gameObject);
            can--;
        }

        if(puan == hedef)
        {
            winpanel.SetActive(true);
            karakter.SetActive(false);
            canpan.SetActive(false);
            puanpan.SetActive(false);
        }

        if (can == 0)                              
        {
            losepanel.SetActive(true);
            karakter.SetActive(false);
            canpan.SetActive(false);
            puanpan.SetActive(false);
        }

    }

}
