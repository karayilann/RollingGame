using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource ses;
    public AudioClip point, wrong;
    
    void Start()
    {
        ses = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.tag == "mini")
        {
            ses.PlayOneShot(point);

        }
        
        if(temas.gameObject.tag == "toplama")
        {
            ses.PlayOneShot(wrong);
        }
    
    }

}
