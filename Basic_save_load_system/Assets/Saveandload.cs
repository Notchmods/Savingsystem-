using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saveandload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detects the current scene.
        Scene currentscene = SceneManager.GetActiveScene();
        //If it's the first scene
        if(currentscene.name == "Level 1")
        {
            //Save the integer as level one 
            PlayerPrefs.SetInt("Scenesaved", 1);
            PlayerPrefs.Save();
        }
        if (currentscene.name == "Level two")
        {
            PlayerPrefs.SetInt("Scenesaved", 2);
            PlayerPrefs.Save();
        }
        if (currentscene.name == "Level 3")
        {
            
            PlayerPrefs.SetInt("Scenesaved", 3);
            PlayerPrefs.Save();
        }
    }

    public void Loadsavedscene()
    {
        //Put the saved scene into an integer.
        int savedscene = PlayerPrefs.GetInt("Scenesaved");
        //Loads the saved scene
        SceneManager.LoadScene(savedscene);
    }
}
