using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Target1 : MonoBehaviour
{
    public int health;
    public AudioSource crash;
    public static int enemyCount = 11;
    public Text text;
    public int damage1 = 20;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + health.ToString();
    }

    public void TakeDamage(int damage)
    {
       health -= damage;

       if(health <= 0)
       {
        SceneManager.LoadScene("MainMenu");
       }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            health -= damage1;
            crash.Play();
            
        }
        if(health <= 0)
        {
           
            SceneManager.LoadScene("MainMenu");
        }

        if(other.gameObject.tag == "EasterEgg")
        {
            health = 350;
            damage1 = 20;
            text.text = "(You Found the Easter egg!)Health: " + health.ToString() ;   
        }

        if(other.gameObject.tag == "shell")
        {
            health-= 10;
        }

        if(other.gameObject.tag == "Milestone")
        {
            SceneManager.LoadScene("MainMenu");
        }

        
    }
}

