using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public GameObject BreakBox;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnCollisionStay(Collision collision)
    {
        Instantiate(BreakBox, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
