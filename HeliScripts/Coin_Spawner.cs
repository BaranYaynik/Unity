using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin_Spawner : MonoBehaviour
{
    public GameObject coin;
    public Controller heliscript;
    public float time;
    private void Start()
    {
        StartCoroutine(spawnobject(time));
       
    }

    public IEnumerator spawnobject(float time) 
    {
        while (!heliscript.isDead) {

        Instantiate(coin, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
        
        }
    }
}
