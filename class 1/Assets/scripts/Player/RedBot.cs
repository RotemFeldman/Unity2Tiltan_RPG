using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBot : MonoBehaviour
{
    [SerializeField] private GameObject _arrow;


    void Start()
    {

    }

    void Update()
    {
        ShowArrow();
    }

    void ShowArrow()
    {
        if (GameManagar.instance == null)
        {
            _arrow.SetActive(false);
            return;
        }

        if (GameManagar.instance.SelectedCharacter == gameObject)
        {
            _arrow.SetActive(true);
        }
        else { _arrow.SetActive(false); }
    }

    private bool IsSelected()
    {
        if (GameManagar.instance.SelectedCharacter == gameObject)
            return true;

        return false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedBot")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
