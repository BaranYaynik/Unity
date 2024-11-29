using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanabilirKup : MonoBehaviour
{
    bool ToplandiMi;
    int index;
    public Toplayici Toplayici;

    void Start()
    {
       ToplandiMi = false;
    }

    
    void Update()
    {
        if(ToplandiMi== true) 
        {
            if (transform.parent != null)
            {
                transform.localPosition =new Vector3(0, -index, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            Toplayici.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetToplandiMi() 
    {
        return ToplandiMi; 
    }
    public void TopladiYap()
    {
        ToplandiMi = true;
    }
    public void ÝndexAyarla(int index)
    {
        this.index = index;
    }

}
