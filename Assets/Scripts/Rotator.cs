using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public enum RotateBase
    {
        X = 0,
        Y = 1,
        Z = 2,
    }

    public RotateBase Direction = RotateBase.X;
    public float speed = 10f;
    private Rigidbody body => GetComponent<Rigidbody>();
    private Vector3 force = Vector3.zero;
    private float val = 10f;

    // Start is called before the first frame update
    void Start()
    {
        force = new Vector3(Direction == RotateBase.X ? 1f : 0f, Direction == RotateBase.Y ? 1f : 0f, Direction == RotateBase.Z ? 1f : 0f );
    }

    void FixedUpdate()
    {
        val = Random.Range(-2f, 2f) * Mathf.Sin(Time.time) * 10f;
        body.AddTorque(val * force * speed * Time.deltaTime, ForceMode.VelocityChange);
    }
    
}
