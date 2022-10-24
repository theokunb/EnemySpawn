using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public bool Spawned {get; private set;}

    public void Spawn(Enemy template, Vector3 position,Quaternion quaternion)
    {
        Spawned = true;
        Instantiate(template, position, quaternion);
    }
}
