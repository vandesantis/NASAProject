﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewProjectController : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 7;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentTaskNum = 0;
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
                    InsertRam();
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
                    break;
                case 3:
                    BackpanelRestart();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
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
        anim.Play("StartBackpanel");
    }

    private void Walk()
    {
        anim.Play("AvatarWalkParent");
    }

    private void WalkRestart()
    {
        anim.Play("WalkStart");
    }
    private void Screws()
    {
        anim.Play("Screwdriver animation");
    }
    private void ScrewsRev()
    {
        anim.Play("Screwdriver animation reverse");
    }
    private void InsertRam()
    {
        anim.Play("Ram_insertion");
    }
}
