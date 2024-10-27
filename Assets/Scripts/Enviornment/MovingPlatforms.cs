using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
[Header("Attributes")]
[SerializeField] Vector3 position1;
[SerializeField] Vector3 position2;

[SerializeField] float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(position1, position2, Mathf.PingPong(Time.time * moveSpeed, 1.0f));
    }


}
