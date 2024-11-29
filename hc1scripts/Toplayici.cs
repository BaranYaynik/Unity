using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject anaKup;
    int yukseklik;
    void Start()
    {
        anaKup = GameObject.Find("Maincube");
    }

    
    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla"&&other.gameObject.GetComponent<toplanabilirKup>().GetToplandiMi()==false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<toplanabilirKup>().TopladiYap();
            other.gameObject.GetComponent<toplanabilirKup>().ÝndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
        }
    }
}
