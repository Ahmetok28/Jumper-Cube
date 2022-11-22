using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject ground;
    private Transform trans;
    public int groundCount;
    public float groundWidth;
    public float miny, maxy;

    void Start()
    {
        trans = ground.GetComponent<Transform>();
        Vector3 spawnLocation = new Vector3();
        Vector2 newScale = new Vector2();
        for (int i = 0; i < groundCount; i++)
        {
            newScale.x = Random.Range(0.9f, 1.1f);
            newScale.y = Random.Range(0.9f, 1.1f);
            trans.localScale = newScale;

            spawnLocation.y += Random.Range(miny, maxy);
            spawnLocation.x = Random.Range(-groundWidth, groundWidth);

            Instantiate(ground, spawnLocation, Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
