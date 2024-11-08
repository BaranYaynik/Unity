using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tspawner : MonoBehaviour
{
    public GameObject Tree;
    public Controller heliscript;
    public float time;
    
    void Start()
    {
        StartCoroutine(spawnobject(time));
        
    }

    public IEnumerator spawnobject(float time)
    {
        while(!heliscript.isDead) { 

        Instantiate(Tree, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
        }
    }
}
