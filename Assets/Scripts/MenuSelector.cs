using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSelector : MonoBehaviour
{
    public Text text;
    public int startIndex;
    public int EndIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void loadRandom()
    {
        // int[] values = {3,3,3,3,3,3,1,2,2,3,2,1,3,3,3,3,3,3,2,2,3,2,1,2,1,1,2,2,1,2, 3, 3,3 ,3 ,2,2,2,2,3,1,2,2,1,1,3,1,1,2,2, 3, 1,2,2,2,1,3, 2,2,3,2,2,2, 3,2,2, 1, 1, 1, 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,1};
        // int random1 = Random.Range(0, values.Length-1);
        // int randomFinal = values[random1];
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + randomFinal);\
        // int random = Random.Range(1, 5);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + random);
        SceneManager.LoadScene("LevelSelctor");
    }

    public void controls()
    {
        text.text = "Controls: Q to Save screenshot. WASD to move. Left mouse button to shoot main barrel, Right mouse button to shoot machine gun. Ram to ram. F to activate Flamethrower, H to boost in to those donks, and c to cancel boost.";
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void loadCliff()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void loadBall()
    {
        SceneManager.LoadScene("DodgeBall!");
    }

    public void loadAirplane()
    {
        SceneManager.LoadScene("AirPlane");
    }

    public void loadProhorovka()
    {
        SceneManager.LoadScene("Prohorovka");
    }

   public void loadPaintball()
   {
    SceneManager.LoadScene("destroyed_city");
   }
}
