using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float horizontalInput;
    public float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);
        transform.Translate(Vector3.back * Time.deltaTime * playerSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
        transform.Translate(Vector3.left * Time.deltaTime * playerSpeed * horizontalInput);
    }
}
