using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DungeonGenerationData.asset", menuName = "DungeonGenerationData/Dungeon Data")]
public class DungeonGenerationData : ScriptableObject
{
    public int numberOfCrawlers;
    public int interationMin;
    public int interationMax;
    public string starterRoomName;
    public string bossRoomName;
    public List<string> roomsNames;
}
