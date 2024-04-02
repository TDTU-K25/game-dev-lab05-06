using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    FaderScript faderScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() 
    {
        StartCoroutine(ChangeLevel());
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator ChangeLevel()
    {
        faderScript = GameObject.FindWithTag("GameController").GetComponent<FaderScript>();
        float time = faderScript.BeginFade(1);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        // SceneManager.LoadScene("Main", LoadSceneMode.Additive);
    }
}
