using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{

    public int BreakPoint = 1;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject CollidedWith = collision.gameObject;
        if (CollidedWith.tag == gameObject.tag)
        {
            --BreakPoint;
        }
    }

    void Update()
    {
        if (BreakPoint == 0)
        {
            Destroy(gameObject);
        }
    }
}
