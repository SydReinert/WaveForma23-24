using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMoveAndDestroy : MonoBehaviour
{
    public int moveSpeed;

    void FixedUpdate()
    {
        this.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime), Space.World);
        if (this.transform.position.z < -2) {
            Destroy(this.gameObject);
        }
    }
}
