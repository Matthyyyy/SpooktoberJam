using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        SceneManager.LoadScene(1);
    }
}
