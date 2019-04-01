using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playgame ()
    {
        SceneManager.LoadScene("tesclimb");
    }
    public void exitgame()
    {
        Application.Quit();
        print("Quit");
    }
}
