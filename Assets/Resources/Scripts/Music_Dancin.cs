using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Dancin : MonoBehaviour
{
    public LoadWalls loadWalls;
    private AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        // Wait until every wall asset have been loaded
        if (loadWalls != null)
        {
            music();
            audioData = GetComponent<AudioSource>();
            audioData.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void music()
    {
        //loadWalls.putWall(1, 0f);
        /*loadWalls.putWall(2, 1f);
        loadWalls.putWall(4, 1.5f);
        loadWalls.putWall(0, 3f);
        loadWalls.putWall(8, 4f);
        loadWalls.putWall(10, 5.5f);
        loadWalls.putWall(9, 6f);
        loadWalls.putWall(1, 7f);
        loadWalls.putWall(3, 8f);
        loadWalls.putWall(5, 8.5f);
        loadWalls.putWall(2, 10f);
        loadWalls.putWall(1, 11f);
        loadWalls.putWall(2, 12f);*/
    }
}
