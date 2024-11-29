using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField]
    private float ileriGitmeHizi;
    [SerializeField]
    private float sagaSolaGitmeHizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal")*sagaSolaGitmeHizi*Time.deltaTime;
        this.transform.Translate(yatayeksen,0,ileriGitmeHizi* Time.deltaTime);
    }
}
