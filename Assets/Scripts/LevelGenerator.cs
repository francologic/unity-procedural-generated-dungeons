using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator : MonoBehaviour
{
    private GameObject[] rooms;

    private List<Vector2> takenPositions = new List<Vector2>();

    public int numberOfRooms = 20;
    public GameObject[] starterRooms;
    public GameObject[] middleRooms;
    public Grid mainGrid;
    public string roomTag;

    void Start()
    {

    }

    public void GenerateRooms()
    {
        SpawnRooms();
    }

    public void CleanSpawnedRooms()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag(roomTag);
        foreach (var room in rooms)
        {
           DestroyImmediate(room); 
        }
    }

    private void SpawnRooms()
    {
        int randomRoom = Random.Range(0, starterRooms.Length);
        GameObject room = Instantiate(starterRooms[randomRoom], new (0,0), Quaternion.identity);
        room.transform.parent = mainGrid.transform;
        takenPositions.Insert(0,new Vector2(0,0));
        
    }
}
