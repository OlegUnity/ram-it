using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyConrollerBad2 : MonoBehaviour
{
    public float lookRadius = 10f;
    // public float damageRadius = 1f;

    public GameObject player;
 


    public GameObject target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = (target.transform.position- transform.position).magnitude;

        if (distance <= lookRadius)
       {
            lookRadius /= 1.2f;//Optional
            agent.SetDestination(player.transform.position);
        }

       

        else//Optional
        {//Optional
            if(lookRadius < 50)//Optional
            {
               lookRadius *= 2f;//Optional
            }//Optional
            Debug.Log("Cant see him!");
            
            
            
        }//Optional


    }

   void OnDrawGizmosSelected()
   {
       Gizmos.color = Color.green;

       Gizmos.DrawWireSphere(transform.position, lookRadius);
        //  Gizmos.DrawWireSphere(transform.position, damageRadius);
   }

  


}
