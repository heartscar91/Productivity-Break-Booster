using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITimer : MonoBehaviour {

    public float CountdownFrom;
    public Text textbox;
    public int sceneLoad;
    public bool isEnabled;
    public bool isStarted = false;

    private void Start()
    {
        this.enabled = isEnabled;
    }

    void Update()
    {
        CountdownFrom = CountdownFrom - Time.deltaTime;
        textbox.text = CountdownFrom.ToString("0.00") + "s";

        if (CountdownFrom <= 0f)
        {
            TimeUp();
        }

  
    }

    void TimeUp()
    {
        SceneManager.LoadScene(sceneLoad);  
    }
}
