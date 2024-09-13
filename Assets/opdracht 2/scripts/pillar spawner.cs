using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarspawner : MonoBehaviour
{

    public GameObject pillar;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            SpawnPillar();
        }
    }
               
    private void SpawnPillar()
    {
        float RandomSize = Random.Range(0.1f, 5f);
     Vector3 Randompos =  new Vector3 (Random.Range(9, -9),1, Random.Range(-9, 9));
      GameObject NewPillar = Instantiate(pillar,Randompos,Quaternion.identity);
        NewPillar.transform.localScale =  new Vector3(RandomSize, RandomSize, RandomSize);
    }

}
