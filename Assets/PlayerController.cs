using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float horMovement = Input.GetAxis("Horizontal");
        float vertMovement = Input.GetAxis("Vertical");
        Debug.Log(horMovement);
        Debug.Log(vertMovement);
    }
}
