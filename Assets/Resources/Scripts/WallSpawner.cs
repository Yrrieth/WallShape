using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    private GameObject[] walls;
    private List<GameObject> listWalls;

    // Start is called before the first frame update
    void Start()
    {
        loadWalls();

    }

    // Update is called once per frame
    void Update()
    {
        foreach(var wall in listWalls)
        {
            wall.transform.position += new Vector3(0, 0, -Time.deltaTime * 10);
        }
        
    }

    void loadWalls()
    {
        int positionZ = 30;
        listWalls = new List<GameObject>();

        /* Charge tous les fichiers contenus dans le dossier à l'adresse suivante
         * (Ces fichiers doivent être préalablement mis dans un dossier nommé "Resources/")
         */
        walls = Resources.LoadAll<GameObject>("Prefabs/Walls");

        Debug.Log(walls.Length);
        foreach (var wall in walls)
        {
            //Debug.Log(wall.name);
            Debug.Log(wall);
            GameObject newWall = Instantiate(wall);
            newWall.transform.position = new Vector3(0, 5, positionZ);
            listWalls.Add(newWall);

            positionZ += 10;
        }

        Debug.Log(walls[0]);
    }
}
