using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;
    //NPC Level
    public int level = 1;
    //NPC Speed
    public float speed = 1.2f;

    Vector3 newPosition = Vector3.zero;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        newPosition.y += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
