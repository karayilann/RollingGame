using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource ses;
    
    void Start()
    {
        ses = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.tag == "mini")
        {
            ses.Play();
            
        }
    }

}
