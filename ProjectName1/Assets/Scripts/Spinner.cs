using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rX;
    [SerializeField] float rY;
    [SerializeField] float rZ;

    void Update()
    {
        transform.Rotate(rX, rY, rZ);
    }
}
