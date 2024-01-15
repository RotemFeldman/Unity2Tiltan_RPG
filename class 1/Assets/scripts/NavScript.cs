using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NavScript : MonoBehaviour
{
    [SerializeField] GameObject DestinationObjectPrefab;
    [SerializeField] NavMeshAgent agent;

    Transform Destination;
    GameObject DestObj;
    void Start()
    {
        DestinationObjectPrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveToMouseClick();

    }

    private void MoveToMouseClick()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);
                DestinationObjectPrefab.transform.position = hit.point;
                DestinationObjectPrefab.SetActive(true);

            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destination")
        {
            collision.gameObject.SetActive(false);
        }
    }

}
