using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
    public int speed = 5;
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime,Space.World);
    }
}
