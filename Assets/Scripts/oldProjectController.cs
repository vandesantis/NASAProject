using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oldProjectController : MonoBehaviour
{
    //public Text taskText;

    //private int currentTaskNum;
    //private int numTasks = 3;
    //private GameObject[][] tasks;
    //    private Text currentTask;
    //private GameObject[] currentTask;
    //private GameObject[] previousTask;

    //private GameObject[] taskTexts;

    //private string[] taskStrings = new string[4];


    //private string task0Text = "Task 0";
    //private string task1Text = "Task 1";
    //private string task2Text = "Task 2";
    //private string task3Text = "Task 3";

    // Start is called before the first frame update
    void Start()
    {
        //taskStrings[0] = "Task 0";
        //taskStrings[1] = "Task 1";
        //taskStrings[2] = "Task 2";
        //taskStrings[3] = "Task 3";
        //print(taskStrings[1]);


        //taskText.text = task1Text;

        //currentTaskNum = 0;
        //currentTask = GameObject.FindGameObjectsWithTag("Task" + currentTaskNum);

        //print(currentTask);
        //foreach (GameObject g in currentTask)
        //{
        //    g.SetActive(true);
        //}

        //print(GameObject.FindGameObjectsWithTag("Task0"));

        //for (int i = 0; i < numTasks; i++)
        //{
        //    print(GameObject.FindGameObjectsWithTag("Task0"));
        //    print(GameObject.FindGameObjectsWithTag("Task" + i));
        //    tasks[i] = GameObject.FindGameObjectsWithTag("Task" + i);
        //}

        //foreach (GameObject[] task in tasks)
        //{
        //    foreach (GameObject g in task)
        //    {
        //        g.SetActive(true);
        //    }
        //}

        //foreach (GameObject g in tasks[currentTaskNum])
        //{
        //    g.SetActive(true);
        //}

        //for (int i = 0; i < taskText.transform.childCount; i++)
        //{
        //    print(taskText.transform.GetChild(i).gameObject);
        //    taskTexts[i] = taskText.transform.GetChild(i).gameObject;
        //}
        //taskTexts[currentTaskNum - 1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextTask()
    {
        //previousTask = currentTask;
        //currentTaskNum++;
        //currentTask = GameObject.FindGameObjectsWithTag("Task" + currentTaskNum);
        //print(taskText.text);
        //print(taskStrings[1]);
        //print(currentTaskNum);
        //print(taskStrings[currentTaskNum]);
        //taskText.text = taskStrings[currentTaskNum];
        //UpdateTask();
    }

    public void UpdateTask()
    {
        //taskTexts[currentTaskNum - 2].SetActive(false);
        //taskTexts[currentTaskNum - 1].SetActive(true);
        //foreach (GameObject g in previousTask)
        //{
        //    g.SetActive(false);
        //}

        //foreach (GameObject g in currentTask)
        //{
        //    g.SetActive(true);
        //}
    }
}