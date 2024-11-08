using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public bool isDead;
    public FixedJoystick joystick;

    public Rigidbody2D rb;
    public GameManager managerGame;
    public GameObject DeathScreen;
    
    Vector2 move;
    public float movespeed;
    


    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        move.x = joystick.Horizontal;
        move.y = joystick.Vertical; 
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * movespeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            SoundManager.instance.coinsource.PlayOneShot(SoundManager.instance.coinsound);
            Destroy(other.gameObject);
            managerGame.updateScore();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }

}

