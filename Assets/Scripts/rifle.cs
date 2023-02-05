using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : MonoBehaviour
{
    public GameObject player;
    public GameObject ballPrefab;
    public int damage = 20;
    public float reloadTime = 3.5f;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 650, Color.green);
        var shootingDistance = 25; 
        var distance = (player.transform.position - transform.position).magnitude;
        if(distance <= shootingDistance)
       {
            StartCoroutine(shootProjectile());
        }
    }

    IEnumerator shootProjectile()
    {
        audio.Play();
        // var projectile = Instantiate
        // (
        //  ballPrefab,
        //  transform.position,
        //  transform.rotation
        // );

        // Debug.Log("We created the object!");

        // var rigidbody = projectile.GetComponent<Rigidbody>();
        // rigidbody.velocity = transform.position * 1;
        // Debug.Log("We shot it!");
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            var target1 = hit.transform.GetComponent<Target1>();
            if(hit.collider.gameObject.tag == "Player" && target1 != null)
            {
                Debug.Log("OWCH!");
                target1.TakeDamage(damage);
                 


            }
             
        }
        yield return new WaitForSeconds(0.2f);

    }
}
