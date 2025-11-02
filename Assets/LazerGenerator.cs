using UnityEngine;

public class LazerGenerator : MonoBehaviour
{
    public GameObject lazerizer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0, 1000) > 950) // Hopefully unlikely enough
        {
            // make a copy of the lazer gameobject.
            Instantiate(lazerizer); // May need transform.position and quaternion.identity
        }
    }
}
