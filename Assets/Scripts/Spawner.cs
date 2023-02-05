using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bot;
    public float rate;
    // Start is called before the first frame update
    void Start()
    {
        
        
         StartCoroutine(Spawn());  
    
        
      
    }

    IEnumerator Spawn()
    {
        while(true)
        {
 
              var bot1 = Instantiate(
            bot,
            transform.position,
            transform.rotation
            
        );

        yield return new WaitForSeconds(3f);
        }
       
       
    }
    }

    // Update is called once per frame
    

