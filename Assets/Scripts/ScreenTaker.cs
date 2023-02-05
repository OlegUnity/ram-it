using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTaker : MonoBehaviour
{
    public  Text Screenshotname;
    string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomNum = Random.Range(0, 1001);
        int letterIndex = Random.Range(0, 26);
        int letterIndex1 = Random.Range(0, 26);
        int letterIndex2 = Random.Range(0, 26);
        int letterIndex3 = Random.Range(0, 26);
        int letterIndex4 = Random.Range(0, 26);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            string name = "FishingRODs_Games-" + Time.time + Time.deltaTime + letters[letterIndex] + letters[letterIndex1] + letters[letterIndex2] + letters[letterIndex3] + letters[letterIndex4] + randomNum+".png";
            ScreenCapture.CaptureScreenshot(name);
            Screenshotname.text = "Screenshot saved. Name: " + name.ToString();
        }
    }
}
