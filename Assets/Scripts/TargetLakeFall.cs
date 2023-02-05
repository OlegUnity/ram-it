using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLakeFall : MonoBehaviour
{
    public int health;
    public AudioSource crash;
    [SerializeField] static int enemyCount = 17;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
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
        enemyCount -= 1;
        Destroy(gameObject);
       }

       if(enemyCount <= 0 )
       {
        Debug.Log("YOU WOJ!!!!!");
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
        }

        
    }
}
