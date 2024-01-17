using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Header("Move")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private float xInput;
    [SerializeField] private float zInput;

    public static CameraController instance;

    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        Vector3 dir = (transform.forward * zInput) + (transform.right * xInput);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Start()
    {
        moveSpeed = 50;
    }

    void Update()
    {
        MoveByKB();
    }
}
