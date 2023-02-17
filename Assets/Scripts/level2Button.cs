using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Button : MonoBehaviour
{
    public GameObject panel;
    public GameObject cansay;
    public GameObject karakter;
    public GameObject cam2;
    public GameObject puansay;
    public void panelOff()
    {
        panel.SetActive(false);
        cansay.SetActive(true);
        karakter.SetActive(true);
        cam2.SetActive(false);
        puansay.SetActive(true);
    }
}
