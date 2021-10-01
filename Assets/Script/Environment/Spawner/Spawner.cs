using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Bird> Birds;
    public List<Enemy> Enemies;

    public int getBirdsCount()
    {
        return Birds.Count;
    }

    public int getEnemyCount()
    {
        return Birds.Count;
    }
}
