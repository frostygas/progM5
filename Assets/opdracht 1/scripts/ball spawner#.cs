using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);
            GameObject ball = CreateBall(randColor);
            DestroyBall(ball);
        }
    }

    private float elapsedTime = 0f;
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            GameObject ball = CreateBall(randColor);
            elapsedTime = 0f;
            DestroyBall(ball);
        }

    }



    internal GameObject CreateBall(Color c)
    {
       Vector3 randompos=  new Vector3(Random.Range(10f, -10f),Random.Range(0f,5f),Random.Range(10f,-10f));  
        GameObject ball = Instantiate(prefab,randompos,Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
             
            //TimeELapsed += Time.deltaTime;
            //if (TimeELapsed > 3f)
            {
                Destroy(ball ,3);            
            }
        
    }


    public GameObject prefab;
}

