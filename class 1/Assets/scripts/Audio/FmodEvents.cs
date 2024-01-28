using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FmodEvents : MonoBehaviour
{
    [field: Header("Gate SFX")]
    [field: SerializeField] public EventReference GateSwitchSound {  get; private set; }







    public static FmodEvents instance {  get; private set; }
    private void Awake()
    {
        if (instance != null)
            Debug.LogWarning("More than one FmodEvents in scene");

        instance = this;
    }
}
