using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotate : MonoBehaviour
{
    [SerializeField] GameObject front = null;
    [SerializeField] GameObject back = null;

    void Update()
    {
        // back of card forward direction (transform.forward) is facing 
        // the same direction as camera forward direction in world space
        // so when dot product of card forward and camera forward is larger than 0
        // meaning card's back and camera forward is facing same direction
        // the front is visible
        if (Camera.main != null)
        {
            if (Vector3.Dot(transform.forward, Camera.main.transform.forward) > 0)
                ShowFront();
            else
                ShowBack();
        }
    }

    void ShowBack()
    {
        if (front != null)
            front.SetActive(false);
        if (back != null)
            back.SetActive(true);
    }

    void ShowFront()
    {
        if (front != null)
            front.SetActive(true);
        if (back != null)
            back.SetActive(false);
    }
}