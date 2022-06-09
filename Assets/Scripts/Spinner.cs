using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float angleX;
    [SerializeField] float angleY = 1f;
    [SerializeField] float angleZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angleX, angleY, angleZ);
    }
}
