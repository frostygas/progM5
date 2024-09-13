using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    internal List<GameObject> enemies = new List<GameObject>();
    [SerializeField] GameObject Enemy;
    float Timer = 0f;
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 1f)
        {
            for (int i = 0; i < 3; i++)
            {
             CreateEnemy(); 
            }
            Timer = 0f;
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            for(int i = 0;i < 100; i++)
            {
                CreateEnemy();
            }
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            for(int i = 0;i < enemies.Count; i++)
            {
                GameObject destroy = enemies[i];
                Destroy(destroy);          
            }
            enemies.Clear();
        }
    }


    private GameObject CreateEnemy()
    {
        GameObject NewEnemy = Instantiate(Enemy);
        enemies.Add(NewEnemy);
        return NewEnemy;
    }

}
