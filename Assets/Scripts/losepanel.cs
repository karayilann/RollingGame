using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losepanel : MonoBehaviour
{
   public void repeat()
   {
        SceneManager.LoadScene("Level2");   
   }

    public void mainmenu()
    {
        SceneManager.LoadScene("giris");
    }

    public void cik()
    {
        Application.Quit();
    }
    
    public void winrepeat()
    {
        SceneManager.LoadScene("Level1");
    }
}
