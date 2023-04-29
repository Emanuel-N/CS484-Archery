using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;

    private void FixedUpdate()
    {
        transform.forward =
            Vector3.Slerp(transform.forward, rb.velocity.normalized, Time.fixedDeltaTime);
    }
}
