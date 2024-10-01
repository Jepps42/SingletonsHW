using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Variables 

    public static GameManager Instance;

    private bool restartScene = true;
    //Awake is called instead of spawn
    private void Awake()
    {
        //A singlton must only have one instance, check to make sure this is the only instance
        //If it is, make sure its not destroyed, if its not destroy this instance
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        if (restartScene)
        {
            SceneManager.LoadScene("SampleScene");
            restartScene = false;
        }
    }
}
