using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevButton : MonoBehaviour
{
    public MeshRenderer m_ButtonHighlight;
    public NewProjectController projectController;

    //public GameObject Laptop, screwdriver;

    private
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnGaze(bool hasGaze)
    {
        m_ButtonHighlight.enabled = hasGaze;
    }

    public void OnSelect()
    {
        //Debug.Log("OnSelect() called on: " + gameObject.name);
        //Laptop.SetActive(true);
        //screwdriver.SetActive(true);

        projectController.PrevTask();
    }
}

