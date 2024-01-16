using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagar : MonoBehaviour
{
    [SerializeField] public GameObject SelectedCharacter;


    public static GameManagar instance;


    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit) )
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Character"))
                {
                    SelectedCharacter = hit.rigidbody.gameObject;
                }
            }
        }
    }

    
}
