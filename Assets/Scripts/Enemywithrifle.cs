using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemywithrifle : MonoBehaviour
{
    public GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    public float lookingRange = 100f;
    public float shootingRange = 25;
    public GameObject ballPrefab;
    public GameObject rifle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distance = (player.transform.position - transform.position).magnitude;
        var capsule = distance;

        if(distance <= 100)
        {
         Debug.Log("We see him!");   
          agent.SetDestination(player.transform.position);
        //   shootProjectile(); 
        }

        else
        {
            if(capsule <= 600)
            {
               capsule *= 2;
            }
        }

        
          
        

    }

    void shootProjectile()
    {
        var projectile = Instantiate
        (
         ballPrefab,
         transform.position,
         transform.rotation
        );

        Debug.Log("We created the object!");

        var rigidbody = projectile.GetComponent<Rigidbody>();
        rigidbody.velocity = transform.position * 300;
        Debug.Log("We shot it!");
    }
}

