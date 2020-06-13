using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftHand"))
        {
            Debug.Log("Left hand");
            Score.isLeftHandDetected = true;
        }
    }
}
