using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalManager : MonoBehaviour {

    public static bool taskStarted = false;
    public static int tasksDone = 0;

    private bool task1Text;
    private bool task2Text;
    private bool task3Text;
    private bool task4Text;
    private bool task5Text;

    private bool task1Done = false;
    private bool task2Done = false;
    private bool task3Done = false;
    private bool task4Done = false;
    private bool task5Done = false;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Task 1 Button") != null)
        {
            if (task1Done == false)
            {
                tasksDone += 1;
                task1Done = true;
            }
        }
        if (GameObject.Find("Task 2 Button") != null)
        {
            if (task2Done == false)
            {
                tasksDone += 1;
                task2Done = true;
            }
        }
        if (GameObject.Find("Task 3 Button") != null)
        {
            if (task3Done == false)
            {
                tasksDone += 1;
                task3Done = true;
            }
        }
        if (GameObject.Find("Task 4 Button") != null)
        {
            if (task4Done == false)
            {
                tasksDone += 1;
                task4Done = true;
            }
        }
        if (GameObject.Find("Task 5 Button") != null)
        {
            if (task5Done == false)
            {
                tasksDone += 1;
                task5Done = true;
            }
        }

        Debug.Log(tasksDone);
    }
}
