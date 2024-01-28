using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class GatePlate : MonoBehaviour
{
    [SerializeField] GameObject Gate;

    private void OnTriggerEnter(Collider other)
    {
        AudioManager.instance.PlayOneShot(FmodEvents.instance.GateSwitchSound , Gate.transform.position);
        Gate.SetActive(false); 
    }

    private void OnTriggerExit(Collider other)
    {
        Gate.SetActive(true);
    }
}
