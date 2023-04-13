using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;

    private void OnTriggerEnter(Collider other)
    {
        GameObject CollidedWith = other.gameObject;
        if (CollidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(CollidedWith);
        }
    }


}
