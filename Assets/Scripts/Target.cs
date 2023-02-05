using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public int health;
     AudioSource crash;
     static int enemyCount = 30;
    public Text YouWonText;
    public ParticleSystem fire;
    
   

    // Start is called before the first frame update
    void Start()
    {
        crash = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemyCount);
    }

    public void TakeDamage(int damage)
    {
       health -= damage;

       if(health <= 0)
       {
        
        Destroy(gameObject);
        enemyCount -= 1;
       }

       if(enemyCount <= 0 )
       {
        Debug.Log("YOU WOJ!!!!!");
        YouWonText.text = "YOU WON!!!!!!!!!!!!!!!!!!!!!!";
        SceneManager.LoadScene("MainMenu");
        enemyCount = 30;
       }
    }

    public void SetOnFire(int damage)
    {
        if(fire != null)
        {

        
        fire.Play();
       Destroy(gameObject, 3f);
       enemyCount -= 1;
        }

        else
        {
          Debug.Log("No Fire!");
        }
        if(enemyCount <= 0 )
       {
        Debug.Log("YOU WOJ!!!!!");
        YouWonText.text = "YOU WON!!!!!!!!!!!!!!!!!!!!!!";
        SceneManager.LoadScene("MainMenu");
        enemyCount = 30;
       }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            
            health -= 20;
            
            crash.Play();
            
            
            
            
            
        }
        if(health <= 0)
        {
           
            Destroy(gameObject);
            enemyCount -= 1;
        }
        if(enemyCount <= 0 )
       {
        Debug.Log("YOU WOJ!!!!!");
        YouWonText.text = "YOU WON!!!!!!!!!!!!!!!!!!!!!!";
        SceneManager.LoadScene("MainMenu");
        enemyCount = 30;
       }

       if(other.gameObject.tag == "shell")
       {
        enemyCount -=1;
        Destroy(gameObject);
       }

       if(other.gameObject.tag == "shell")
       {
        health -=20;
       }

        
    }

  
        
        
}
