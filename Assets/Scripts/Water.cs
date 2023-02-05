using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Col)
    {
        if(Col.gameObject.tag == "Water")
        {
            Debug.Log("No!! Wait! what about fcking dieing?!");
            StartCoroutine(Die());
            Destroy(gameObject);
        }
    }

    IEnumerator Die()
    {
        Debug.Log("Were here");
        yield return new WaitForSeconds(5f);
    }
}
