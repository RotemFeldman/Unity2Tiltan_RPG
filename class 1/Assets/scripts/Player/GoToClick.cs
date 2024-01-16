using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class GoToClick : MonoBehaviour
{
    private const string VELOCITY_ANIMATOR_PARAMETER = "Velocity";

    [SerializeField] GameObject DestinationObjectPrefab;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Animator animator;


    void Start()
    {
        DestinationObjectPrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSelected())
        {
            MoveToMouseClick();
        }

        if (!IsSelected())
        {
            animator.SetFloat(VELOCITY_ANIMATOR_PARAMETER, agent.velocity.magnitude);
        }
    }

    private void MoveToMouseClick()
    {

        animator.SetFloat(VELOCITY_ANIMATOR_PARAMETER, agent.velocity.magnitude);

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Character"))
                {
                    return;
                }

                agent.SetDestination(hit.point);
                DestinationObjectPrefab.transform.position = hit.point;
                DestinationObjectPrefab.SetActive(true);

            }
        }
    }

    private bool IsSelected()
    {
        if (GameManagar.instance.SelectedCharacter == gameObject)
            return true;

        return false;
    }







}
