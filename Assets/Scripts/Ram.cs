using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{
    private Animator A;
    // Start is called before the first frame update
    void Start()
    {
        A=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        A.Play("total");
    }
}
