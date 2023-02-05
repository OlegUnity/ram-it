using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisom : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            health -= 20;
            StartCoroutine(Wait());
        }
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
    }

   
}
