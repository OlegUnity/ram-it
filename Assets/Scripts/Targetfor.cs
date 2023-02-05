using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetfor : MonoBehaviour
{
    public int health12 = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "bullet")
        {
              health12 -= 20;
        }

        if(health12 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
