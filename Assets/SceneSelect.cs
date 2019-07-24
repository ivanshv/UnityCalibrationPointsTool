using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    
    public void selectScene()
    {
        switch (this.gameObject.name) {
            case "Button":
            SceneManager.LoadScene ("25points");
            break;
            case "Button1":
            SceneManager.LoadScene ("81points");
            break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
