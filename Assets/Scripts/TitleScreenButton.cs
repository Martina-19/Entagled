using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//!!!!DONT FORGET TO ADD THESE!!!!
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public Button PlayButton; //these are to link the actual button on unity
    
    // Start is called before the first frame update
    
    void Start()
    {
        PlayButton.onClick.AddListener(Play); // (Play) is the function

    }

    void Play()//start functions
    {
        SceneManager.LoadScene("SampleScene"); //"    " is the name of the scene
    }
}
