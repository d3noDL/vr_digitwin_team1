using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Helicopter : MonoBehaviour
{
    [SerializeField] Transform topRotor, backRotor;

    [SerializeField] private AudioSource[] speakers;
    
    private AudioSource aud;
    private PlayableDirector dir;
    private GameObject instruct, button;
    private bool isReadyToDepart;
    
    private void Start() {
        aud = GetComponent<AudioSource>();
        dir = GetComponent<PlayableDirector>();
        instruct = GameObject.Find("UIHelicopter");
        button = GameObject.Find("UIButton");
    }

    private void Update() {
        topRotor.Rotate(Vector3.forward, 50, Space.Self);
        backRotor.Rotate(Vector3.up, 50, Space.Self);
    }

    public void Arrive() {
        foreach (var player in speakers) {
            player.Stop();
        }
        
        dir.time = 0;
        dir.Play();
        aud.Play();
        button.SetActive(false);
    }

    public void Leave() {
        dir.time = 11;
        dir.Play();
        instruct.SetActive(false);
    }

    public void HasArrived() {
        instruct.SetActive(true);
        dir.Stop();
        dir.time = 10;
        
    }
}
