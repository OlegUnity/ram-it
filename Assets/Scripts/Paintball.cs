using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintball : MonoBehaviour
{
    public AudioSource shoot;
    public GameObject ballPrefab;
    public AudioSource reload;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        var projectile = Instantiate
        (
           ballPrefab,
           transform.position,
           transform.rotation
        );

        var rigidbody = projectile.GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 300;
        
        var collider = projectile.GetComponent<Collider>();
        var ourCollider = GetComponent<Collider>();

        if(collider != null && ourCollider != null)
        {
            Physics.IgnoreCollision(collider, ourCollider);
        }
        
        
    }
}
