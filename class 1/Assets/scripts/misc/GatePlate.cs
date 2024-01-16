using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatePlate : MonoBehaviour
{
    [SerializeField] GameObject Gate;

    private void OnTriggerEnter(Collider other)
    {
        Gate.SetActive(false); 
    }

    private void OnTriggerExit(Collider other)
    {
        Gate.SetActive(true);
    }
}
