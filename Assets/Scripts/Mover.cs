using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0.00f;
    //[SerializeField] float zValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * 2 * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * 2 * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
