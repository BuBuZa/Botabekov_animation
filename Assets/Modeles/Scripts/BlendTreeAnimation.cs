using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTreeAnimation : MonoBehaviour
{
    Animator animator;
    float velosity = 0.0f;
    public float acceleration = 0.1f;
    public float decceleration = 0.5f;
    int VelocityHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        VelocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed && velosity < 5.0f)
        {
            velosity += Time.deltaTime * acceleration;
        }
        if (!forwardPressed && velosity > 0.0f)
        {
            velosity -= Time.deltaTime * decceleration;
        }
        if (!forwardPressed && velosity < 0.0f)
        {
            velosity = 0.0f;
        }
        animator.SetFloat(VelocityHash, velosity);
    }
}
