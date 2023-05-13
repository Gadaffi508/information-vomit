using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    int radius;
    Vector3 spawnPosition;

    void Start()
    {
        LootAngle myLootAngle = new LootAngle(45);

        //every call will advance the angle!
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
    }

    void SpawnPotion(int angle)
    {
        radius = 5;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}
public class LootAngle
{
    int angle;
    int step;

    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }

    public int NextAngle()
    {
        int currentAngle = angle;
        angle = angle + step;

        return currentAngle;
    }
}
class Vector3A
{
    float x;
    float y;
    float z;

    Vector3 otherVector;
}
