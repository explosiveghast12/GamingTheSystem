using UnityEngine;
using System;

public class Lazer : MonoBehaviour
{
    int nextLazer = 0; // We use three variables to make the code easier to read, not for optimization.
    int lazerDelay = 0;
    int lazerCooldown = 0;
    float lazerX = 0;
    float lazerY = 0;
    bool danger = false;

    public LineRenderer linear;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setUpLazer();
        nextLazer = 100;
    }

    // Need to add display color transitions.
    // Update is called once per frame
    void Update() // Should probably use a fixed update and/or time.deltaTime
    {
        if (nextLazer > 0)
        {
            nextLazer--;
        }
        else if (nextLazer == 0)
        {
            // Get random time interval for next thing.
            lazerDelay = UnityEngine.Random.Range(100, 1000);
        }
        if (lazerDelay > 0)
        {
            lazerDelay--;
        }
        else if (lazerDelay == 0)
        {
            // Detect lazer collisions
            danger = true;
            lazerCooldown = UnityEngine.Random.Range(500, 5000);
        }
        if (lazerCooldown > 0)
        {
            lazerCooldown--;
        }
        else if (lazerCooldown == 0)
        {
            // remove lazer display and collision.
            danger = false;
            nextLazer = UnityEngine.Random.Range(1000, 10000);
        }
    }

    void setLazerPosition()
    {
        float x = UnityEngine.Random.Range(0, 100);
        List<Vector2> points = new List<Vector2>();
        // Randomly choose two points on opposite sides of screen
        points.Add(new Vector2(x, 0));
        points.Add(new Vector2(0, x));
        // Choose an angle and Point on screen I guess.
        linear.SetPositions(points);
    }

    void checkLazer()
    {
        // Linecast line
    }

    void setUpLazer()
    {
        List<Vector2> points = new List<Vector2>();
        // https://generalistprogrammer.com/tutorials/unity-line-renderer-tutorial
        linear = gameObject.AddComponent<LineRenderer>();

        // Set up things:
        linear.color = Color.white;
        linear.positionCount = 2;

        points.Add(new Vector2(0, 0));
        points.Add(new Vector2(100, 100));

        linear.SetPositions(points);
    }
}
