using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class falling : MonoBehaviour
{
    public Collider e176;

    void Start()
    {
        e176 = GetComponent<Collider>();
        e176.isTrigger = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        e176.attachedRigidbody.useGravity = true;
    }

}