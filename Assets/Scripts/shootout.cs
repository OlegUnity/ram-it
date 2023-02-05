using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootout : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawRay(transform.position, transform.forward * 40, Color.red);
      StartCoroutine(Shoot());
    }

    // Update is called once per frame
    IEnumerator Shoot()
    {
        
        while(true)
        {
            shootBall();

        yield return new WaitForSeconds(3f);
        
        }
        
    }

    void shootBall()
    {
       var projectile = Instantiate(
       
        ballPrefab,
        transform.position,
        transform.rotation
       );

       var rigidbody = projectile.GetComponent<Rigidbody>();
       if(rigidbody != null)
       {
             rigidbody.velocity = transform.forward * 100;

       }
       else
       {
          Debug.LogError("U western spy no rigid body!");
       }

       var collider = projectile.GetComponent<Collider>();
       var  mycollider = this.GetComponent<Collider>();
       if(collider != null && mycollider != null)
       {
        Physics.IgnoreCollision(collider, mycollider);
       }

       
    }
}
