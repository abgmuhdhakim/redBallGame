using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float xAngle = 3f;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
