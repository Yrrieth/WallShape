using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public static bool isHeadDetected;
    public static bool isRightHandDetected;
    public static bool isLeftHandDetected;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isHeadDetected = false;
        isRightHandDetected = false;
        isLeftHandDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isHeadDetected + " " + isRightHandDetected + " " + isLeftHandDetected);
        if ((isHeadDetected && isRightHandDetected && isLeftHandDetected) == true)
        {
            score += 100;
            GetComponent<UnityEngine.UI.Text>().text = "Score\n" + score;

            isHeadDetected = false;
            isRightHandDetected = false;
            isLeftHandDetected = false;
        }
        
    }
}
