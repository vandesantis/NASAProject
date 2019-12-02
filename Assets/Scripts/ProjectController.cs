using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectController : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 11;

    public Text taskText;
    private string[] taskStrings;
    private bool prev;


    public Animator[] aniList = new Animator[5];

    // Start is called before the first frame update
    void Start()
    {
        taskStrings = new string[numTasks];
        taskStrings[0] = "Task 0: Remove battery";
        taskStrings[1] = "Task 1: Unscrew back panel";
        taskStrings[2] = "Task 2: Remove back panel";
        taskStrings[3] = "Task 3: Remove ram from slot";
        taskStrings[4] = "Task 4: Insert new ram";
        taskStrings[5] = "Task 5: Put on back panel";
        taskStrings[6] = "Task 6: Screw in back panel";
        taskStrings[7] = "Task 7: Replace battery";
        taskStrings[8] = "Task 8";
        taskStrings[9] = "Task 9";
        taskStrings[10] = "Task 10";
        //taskStrings[11] = "Task 11";
        //taskStrings[12] = "Task 12";
        //taskStrings[13] = "Task 13";
        //taskStrings[14] = "Task 14";
        //taskStrings[15] = "Task 15";

        currentTaskNum = 0;
        taskText.text = taskStrings[currentTaskNum];

        foreach (Animator ani in aniList) {
            if (ani == null)
            {
                continue;
            }
            ani.enabled = false;
        }
        aniList[0].enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PrevTask();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            NextTask();
        }

    }

    public void NextTask()
    {
        if (currentTaskNum >= numTasks-1)
        {
            return;
        }
        currentTaskNum++;

        //aniList[currentTaskNum].enabled = true;
        for(int i = 0; i < 5; i++)
        {
            if (aniList[i] == null)
            {
                continue;
            }
            if (i == currentTaskNum)
            {
                aniList[i].enabled = true;
            }
            else
            {
                if(i == (currentTaskNum - 1))
                {
                    aniList[i].Play("Battery", -1, 1.0f);
                    aniList[i].Play("Screws", -1, 1.0f);
                    aniList[i].Play("BackPanel", -1, 1.0f);
                    Debug.Log("Skipping Animation");
                    Debug.Log(i);
                }
                //aniList[i].enabled = false;
            }
        }

        aniList[currentTaskNum].Play("Battery", -1, 0.0f);
        aniList[currentTaskNum].Play("Screws", -1, 0.0f);
        aniList[currentTaskNum].Play("BackPanel", -1, 0.0f);
        taskText.text = taskStrings[currentTaskNum];
    }

    public void PrevTask()
    {
        if (currentTaskNum == 0)
        {
            return;
        }
        
        aniList[currentTaskNum].Play("Battery", -1, 0.0f);
        aniList[currentTaskNum].Play("Screws", -1, 0.0f);
        aniList[currentTaskNum].Play("BackPanel", -1, 0.0f);
        prev = true;
        StartCoroutine(prevTimer());
        Debug.Log("Disabling");
        //aniList[currentTaskNum].enabled = false;
        currentTaskNum--;
        aniList[currentTaskNum].enabled = true;
        aniList[currentTaskNum].Play("Battery", -1, 0.0f);
        aniList[currentTaskNum].Play("Screws", -1, 0.0f);
        aniList[currentTaskNum].Play("BackPanel", -1, 0.0f);
        taskText.text = taskStrings[currentTaskNum];
        //aniList[currentTaskNum+1].enabled = false;
    }

    IEnumerator prevTimer()
    {
        prev = false;
        Debug.Log("Waiting");
        yield return new WaitForSeconds(.001f);
        aniList[currentTaskNum+1].enabled = false;
        
    }
}
