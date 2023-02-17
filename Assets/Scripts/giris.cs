using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class giris : MonoBehaviour
{
    public GameObject sespaneli;
    public GameObject girismenu;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void baslat()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void ses()
    {
        sespaneli.SetActive(true);
        girismenu.SetActive(false);
    }

    public void cik()
    {
        Application.Quit();
    }

}
