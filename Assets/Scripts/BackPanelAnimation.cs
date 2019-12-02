using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPanelAnimation : MonoBehaviour
{
    public GameObject backpanel;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            BackPanel();
        }
    }

    //private IEnumerator BackPanel()
    //{
    //    anim.Play("BackPanel");
    //    //anim.SetBool("Audio", true);
    //    //GetComponent<AudioSource>().Play();
    //    //yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
    //    //anim.SetBool("Audio", false);
    //}

    private void BackPanel()
    {
        anim.Play("AvatarBackpanel");
        backpanel.transform.parent = this.transform;
    }
}
