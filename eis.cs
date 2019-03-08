using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eis : MonoBehaviour {

    public float iceFriction;
    public bool aufEis = false;
    public bool colliding = false;
    public float geschw;
    public float drehmom;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertikal = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertikal);

        GetComponent<Rigidbody>().AddForce(movement * geschw * Time.deltaTime);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * drehmom * moveHorizontal);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * drehmom * moveVertikal);
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Eis")
        {
            GetComponent<Collider>().material.dynamicFriction = 0;
        }
    }*/

    private void OnCollisionStay(Collision collision)
    {
        colliding = true;

        if (collision.gameObject.CompareTag("Eis"))
        {
            aufEis = true;
        }
    }
}
