using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility : MonoBehaviour
{
    void OnSceneLoaded(int level)
    {
            Cursor.visible = true;
            Debug.Log("Sceen was loaded");
        // if (FindObjectOfType<FirstPersonController>() != null)
        // {
        //     Cursor.visible = false;
        // }
        // else
        // {
        //     Cursor.visible = true;
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
