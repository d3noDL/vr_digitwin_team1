using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField] Transform topRotor, backRotor;

    private AudioSource aud;
    
    private void Start() {
        aud = GetComponent<AudioSource>();
    }

    private void Update() {
        topRotor.Rotate(Vector3.up, 10, Space.World);
        backRotor.Rotate(Vector3.forward, 10, Space.World);
    }
}
