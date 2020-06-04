using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWalls : MonoBehaviour
{
    public static GameObject[] wallModel;
    public static List<GameObject> activeListWall;

    public int speedWall;

    // Start is called before the first frame update
    void Start()
    {
        loadWallModel();
    }

    // Update is called once per frame
    void Update()
    {
        // Remove from the list if a wall doesn't exist
        activeListWall.RemoveAll(GameObject => GameObject == null);
        
        moveWall(speedWall);
    }

    public void loadWallModel()
    {
        activeListWall = new List<GameObject>();

        /* Charge tous les fichiers contenus dans le dossier à l'adresse suivante
         * (Ces fichiers doivent être préalablement mis dans un dossier nommé "Resources/")
         */
        wallModel = Resources.LoadAll<GameObject>("Prefabs/Walls");
    }

    public void putWall(int wallNumber, float delayTime)
    {
        StartCoroutine(createWall(wallNumber, delayTime));
    }

    IEnumerator createWall(int wallNumber, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);

        GameObject currentWall = Instantiate(wallModel[wallNumber]);
        currentWall.transform.position = new Vector3(0, 5, 50);
        currentWall.tag = "Wall";
        currentWall.GetComponent<Collider>().isTrigger = true;
        if (currentWall.GetComponent<Rigidbody>() == null) {
            currentWall.AddComponent<Rigidbody>();
        }
        currentWall.GetComponent<Rigidbody>().useGravity = false;
        
        activeListWall.Add(currentWall);
    }

    void moveWall(int movementSpeed)
    {
        foreach(var currentWall in activeListWall)
        {
            currentWall.transform.position += new Vector3(0, 0, -Time.deltaTime * movementSpeed);
        }
    }
}
