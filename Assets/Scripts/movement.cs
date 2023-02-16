using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float harekethizi;
    public float donmehizi;
    //Rigidbody rb;
    //public float ziplamamesafesi;
    void Start()
    {

        //rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {
    
        
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            transform.Translate(0, 0, 0.5f * harekethizi);
        }
        
        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            transform.Translate(0, 0, -0.5f * harekethizi);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Rotate(-Vector3.up * donmehizi);
        }
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Rotate(Vector3.up * donmehizi);
        }

        //if (Input.GetKeyDown(KeyCode.Space))                  Ýlk levelde gerekli olmadýðý ve tam çalýþmadýðý için kapatýldý.
        //{ 
        //    transform.Translate(0, ziplamamesafesi + 3, 0);
        //    //GetComponent<Rigidbody>().AddForce(Vector3.up * ziplamagucu);
        //    //rb.AddForce(Vector3.up * ziplamagucu);
        //}
    
    }

   


}
