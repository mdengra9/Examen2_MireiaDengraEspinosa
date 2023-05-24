using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour

{
    private Transform target;

    public Vector3 offset;
    public Vector2 limitX;
    public Vector2 limitY;

    void Start()
    {
        target = GameObject.Find("Mario").GetComponent<Transform>(); 
    }

    void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset;

        float clampX = Mathf.Clamp(desiredPosition.x, limitX.x, limitX.y);
        float clampY = Mathf.Clamp(desiredPosition.y, limitY.x, limitY.y);

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

        transform.position = clampedPosition;
    }
}