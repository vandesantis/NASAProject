using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
//    public GameObject backpanel;
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
            //StartCoroutine(BackPanel());
            Walk();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            //StartCoroutine(BackPanel());
            WalkRestart();
        }
    }

    private void Walk()
    {
        anim.Play("AvatarWalkParent");
    }

    private void WalkRestart()
    {
        anim.Play("WalkStart");
    }

    //private IEnumerator BackPanel()
    //{
    //    anim.Play("AvatarBackpanel");
    //    yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
    //    backpanel.transform.parent = this.transform;
    //    anim.Play("AvatarBackpanel2");

    //    //anim.SetBool("Audio", true);
    //    //GetComponent<AudioSource>().Play();
    //    //yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
    //    //anim.SetBool("Audio", false);
    //}

    //private void BackPanel()
    //{
    //    anim.Play("AvatarBackpanel");
    //    backpanel.transform.parent = this.transform;
    //    anim.Play("AvatarBackpanel2");
    //}
}
