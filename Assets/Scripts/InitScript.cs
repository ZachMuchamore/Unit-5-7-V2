using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        SceneManager.LoadScene("StartMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
