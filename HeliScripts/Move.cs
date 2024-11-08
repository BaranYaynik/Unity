using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    

    private void Start()
    {         
            Destroy(gameObject,16);
        
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed* Time.deltaTime;
    }
}
