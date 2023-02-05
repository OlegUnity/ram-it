using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water1 : MonoBehaviour
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
            SceneManager.LoadScene("MainMenu");
        }
    }

    IEnumerator Die()
    {
        Debug.Log("Were here");
        yield return new WaitForSeconds(5f);
    }
}
