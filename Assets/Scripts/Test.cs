using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void TestButtonScript(string myMessage)
    {
        Debug.Log(myMessage);
    }

    public void LoadScene(string NewGame)
    {
        SceneManager.LoadScene(NewGame);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
