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
            dance();
            audioData = GetComponent<AudioSource>();
            audioData.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void dance()
    {
        loadWalls.putWall(1, 0f);
        loadWalls.putWall(2, 1f);
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
        loadWalls.putWall(2, 12f);
        loadWalls.putWall(9, 13f);
        loadWalls.putWall(8, 14f);
        loadWalls.putWall(9, 15f);
        loadWalls.putWall(8, 16f);
        loadWalls.putWall(10, 16.5f);
        loadWalls.putWall(7, 17f);
        loadWalls.putWall(0, 18f);
        loadWalls.putWall(4, 19f);
        loadWalls.putWall(3, 20f);
        loadWalls.putWall(1, 21f);
        loadWalls.putWall(2, 22f);
        loadWalls.putWall(4, 22.5f);
        loadWalls.putWall(3, 23f);
        loadWalls.putWall(8, 24f);
        loadWalls.putWall(9, 25f);
        loadWalls.putWall(10, 26f);
        loadWalls.putWall(7, 27f);
        loadWalls.putWall(5, 28f);
        loadWalls.putWall(6, 29f);
        loadWalls.putWall(5, 30f);
        loadWalls.putWall(6, 31f);
        loadWalls.putWall(5, 32f);
        loadWalls.putWall(6, 33f);
        loadWalls.putWall(5, 34f);
        loadWalls.putWall(6, 35f);
        loadWalls.putWall(5, 36f);
        loadWalls.putWall(6, 37f);
        loadWalls.putWall(5, 38f);
        loadWalls.putWall(6, 39f);
        loadWalls.putWall(5, 40f);
        loadWalls.putWall(0, 41f);
        loadWalls.putWall(0, 42f);

        loadWalls.putWall(3, 44f);
        loadWalls.putWall(4, 45f);
        loadWalls.putWall(3, 46f);
        loadWalls.putWall(4, 47f);
        loadWalls.putWall(3, 48f);
        loadWalls.putWall(4, 49f);
        loadWalls.putWall(3, 50f);
        loadWalls.putWall(4, 51f);
        loadWalls.putWall(3, 52f);
        loadWalls.putWall(4, 53f);
        loadWalls.putWall(3, 54f);
        loadWalls.putWall(4, 55f);
        loadWalls.putWall(3, 56f);
        loadWalls.putWall(4, 57f);
        loadWalls.putWall(3, 58f);
        loadWalls.putWall(0, 59f);
        loadWalls.putWall(0, 60f);

        loadWalls.putWall(1, 63f);
        loadWalls.putWall(2, 64f);
        loadWalls.putWall(0, 66f);
        loadWalls.putWall(9, 67f);
        loadWalls.putWall(5, 68f);
        loadWalls.putWall(3, 69f);
        loadWalls.putWall(5, 69.5f);
        loadWalls.putWall(1, 71f);
        loadWalls.putWall(7, 72f);
        loadWalls.putWall(4, 72.5f);
        loadWalls.putWall(8, 73f);
        loadWalls.putWall(2, 75f);

        loadWalls.putWall(9, 76f);
        loadWalls.putWall(8, 77f);
        loadWalls.putWall(9, 78f);
        loadWalls.putWall(8, 79f);
        loadWalls.putWall(9, 80f);
        loadWalls.putWall(8, 81f);
        loadWalls.putWall(9, 82f);
        loadWalls.putWall(8, 83f);
        loadWalls.putWall(10, 84f);
        loadWalls.putWall(8, 85f);
        loadWalls.putWall(9, 86f);
        loadWalls.putWall(10, 87f);
        loadWalls.putWall(7, 88f);
        loadWalls.putWall(10, 89f);
        loadWalls.putWall(7, 90f);

        loadWalls.putWall(0, 92f);
        loadWalls.putWall(0, 93f);
    }
}
