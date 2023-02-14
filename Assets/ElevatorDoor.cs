using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : MonoBehaviour
{
    private Animator anim;
    private AudioSource aud;
    private bool isOpen;

    private void Start() {
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }
    
    public void OpenDoor(){
        if(!isOpen){
            anim.SetTrigger("open");
            aud.Play();
            isOpen = true;
        }
    }
}
