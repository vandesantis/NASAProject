#pragma strict
var anim:Animator;

function Start () {

}

function Update () {
if(Input.GetKeyDown(KeyCode.T)){
Talk();
}
}

function Talk(){
anim.SetBool("Audio", true);
GetComponent.<AudioSource>().Play();
yield WaitForSeconds(GetComponent.<AudioSource>().clip.length);
anim.SetBool("Audio", false);
}
