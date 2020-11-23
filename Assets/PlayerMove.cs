using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    Vector3 checkpoint;

    void Start()
    {
        checkpoint = transform.position;
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
    }

    public void SetCheckpoint(Vector3 position)
    {
        checkpoint = position;
    }

    public void GoToCheckpoint()
    {
        transform.position = checkpoint;
    }
}
