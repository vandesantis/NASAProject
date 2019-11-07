using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeProcess : MonoBehaviour
{
    public MeshRenderer m_ButtonHighlight;

    public GameObject taskProcess;

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

        taskProcess.SetActive(true);
    }
}
