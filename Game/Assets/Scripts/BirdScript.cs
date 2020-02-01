using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private SpriteRenderer spriteRendererComponent;
    public GameObject bird;
    public Vector2 spriteSize;
    Vector2 position;
    public float nextSpawn;

    private void Awake()
    {
        spriteRendererComponent = GetComponent<SpriteRenderer>();
    }
    public void Start()
    {
        if (spriteRendererComponent != null)
        {
            spriteSize = spriteRendererComponent.transform.lossyScale;
            Debug.Log(spriteSize);
        }
        nextSpawn = Time.time + 2;

    }

    public void Update()
    {
        if (Time.time > nextSpawn)
        {
            position = new Vector2(Random.Range(0f, 300f), Random.Range(0.0f, 300f));
            Instantiate(bird, position, Quaternion.identity);



            nextSpawn += 2;
        }
    }
}
