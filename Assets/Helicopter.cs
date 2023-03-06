using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Helicopter : MonoBehaviour
{
    [SerializeField] Transform topRotor, backRotor;

    [SerializeField] private AudioSource[] speakers;
    [SerializeField] private AudioClip cloudMusic;
    
    private AudioSource aud;
    private PlayableDirector dir;
    private GameObject instruct, button;
    private bool isReadyToDepart;
    
    private void Start() {
        aud = GetComponent<AudioSource>();
        dir = GetComponent<PlayableDirector>();
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
    }

    public void Leave() {
        dir.time = 11;
        dir.Play();
    }

    public void HasArrived() {
        dir.Stop();
        dir.time = 10;
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("MusicChange")) {
            aud.Stop();
            aud.clip = cloudMusic;
            aud.Play();
        }
    }
}
