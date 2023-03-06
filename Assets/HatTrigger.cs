using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HatTrigger : MonoBehaviour
{
    public UnityEvent OnGraduated;
    public Helicopter heli;
    public GameObject[] heliTriggers;
    
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Hat")){
            heli.Arrive();
            Debug.Log("Helikopter");
            foreach (var trigger in heliTriggers) {
                trigger.SetActive(false);
            }
        }
    }
}
