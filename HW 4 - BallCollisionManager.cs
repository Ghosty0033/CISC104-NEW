using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCollisionManager : MonoBehaviour
{
    static int ballCollisionCount = 0;
    static int wallCollisionCount = 0;

    private TextMeshPro ballCountText;
    private TextMeshPro wallCountText;

    void Start()
    {
        GameObject ballCountGameObject = GameObject.Find("BallCollisionCount");
        GameObject wallCountGameObject = GameObject.Find("WallCollisionCount");

        ballCountText = ballCountGameObject.GetComponent<TextMeshPro>();
        wallCountText = wallCountGameObject.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        ballCountText.text = "Ball Collision Count: " + ballCollisionCount;
        wallCountText.text = "Wall Collision Count: " + wallCollisionCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check for ball collisions
        if (collision.gameObject.tag == "Ball")
        {
            if (this.gameObject.name == "BlackBall")
            {
                ballCollisionCount--;
            }
            else
            {
                ballCollisionCount++;
            }
        }

        // Check for wall collisions
        if (collision.gameObject.tag == "Wall")
        {
            if (this.gameObject.name == "BlackBall")
            {
                wallCollisionCount--;
            }
            else
            {
                wallCollisionCount++;
            }
        }
    }
}
