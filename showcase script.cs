using UnityEngine;

public class showCase : MonoBehaviour
{

    public Rigidbody rb; //creates a slot where we can drag the rigidbody component into

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //rb.AddForce(x, y, z), adds a force to the object (push)
    }
}


//Examples & Explanations:
//Debug.Log("Hello World!");    //Debug.Log works similar to Console.WriteLine
//rb.useGravity = false;        //you can access parts of the component by using the componentname.aspectWeWantToChange
//Time.deltaTime is the amount of seconds since the computer drew the last frame