using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingScript : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(Talk());
        }

    }

    private IEnumerator Talk()
    {
        anim.SetBool("Audio", true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        anim.SetBool("Audio", false);
    }
}
