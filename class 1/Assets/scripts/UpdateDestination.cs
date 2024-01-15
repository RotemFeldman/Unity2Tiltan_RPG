using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateDestination : MonoBehaviour
{


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
             Physics.Raycast(Input.mousePosition, Vector3.down,out RaycastHit hitInfo);
             Transform hit = hitInfo.collider.transform;
        }
    }
}
