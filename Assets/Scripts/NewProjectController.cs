using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewProjectController : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 7;

    //public Text taskText;
    //private string[] taskStrings;
    //private bool prev;

    private Animator anim;
    private Animator cam;

    // Start is called before the first frame update
    void Start()
    {
        //taskStrings = new string[numTasks];
        //taskStrings[0] = "Task 1: Remove battery";
        //taskStrings[1] = "Task 2: Unscrew back panel";
        //taskStrings[2] = "Task 3: Remove back panel";
        //taskStrings[3] = "Task 4: Remove ram from slot";
        //taskStrings[4] = "Task 5: Insert new ram";
        //taskStrings[5] = "Task 6: Put on back panel";
        //taskStrings[6] = "Task 7: Screw in back panel";
        //taskStrings[7] = "Task 7: Replace battery";
        //taskStrings[8] = "Task 8";
        //taskStrings[9] = "Task 9";
        //taskStrings[10] = "Task 10";


        anim = GetComponent<Animator>();
        cam = GetComponent<Animator>();
        currentTaskNum = 0;
        //taskText.text = taskStrings[currentTaskNum];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            switch (currentTaskNum)
            {
                case 0:
                    Walk();
                    break;
                case 1:
                    Screws();
                    break;
                case 2:
                    Backpanel();
                    break;
                case 3:
                    RamInsertion();
                    break;
                case 4:
                    break;
                case 5:
                    BackpanelRev();
                    break;
                case 6:
                    ScrewsRev();
                    break;
                case 7:
                    break;
            }
            currentTaskNum++;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            switch (currentTaskNum)
            {
                case 0:
                    break;
                case 1:
                    WalkRestart();
                    break;
                case 2:
                    ScrewsRestart();
                    break;
                case 3:
                    BackpanelRestart();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    BackpanelRevRestart();
                    break;
                case 7:
                    ScrewsRevRestart();
                    break;
            }
            currentTaskNum--;
        }
    }

    private void Backpanel()
    {
        anim.Play("AvatarBackPanelParent");
    }

    private void BackpanelRev()
    {
        anim.Play("AvatarBackPanelParentRev");
    }

    private void BackpanelRestart()
    {
        anim.Play("BackPanelStart");
        //anim.Play("AvatarBackPanelParent");
    }

    private void BackpanelRevRestart()
    {
        anim.Play("BackPanelRevStart");
    }

    private void Walk()
    {
        anim.Play("AvatarWalkParent");
    }

    private void WalkRestart()
    {
        anim.Play("WalkStart");
        //anim.Play("AvatarWalkParent");
    }
    private void Screws()
    {
        anim.Play("Screwdriver animation");
    }
    private void ScrewsRev()
    {
        anim.Play("Screwdriver reverse animation");
    }
    private void ScrewsRestart()
    {
        anim.Play("Screwdriver start");
        //anim.Play("Screwdriver animation");
    }
    private void ScrewsRevRestart()
    {
        anim.Play("Screwdriver reverse start");
        //anim.Play("Screwdriver animation");
    }
    private void RamInsertion()
    {
        anim.Play("Ram_insertion");
    }
   
}
