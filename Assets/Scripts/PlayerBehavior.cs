using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerBehavior : MonoBehaviour
{
    public Transform Target;
    //public float Speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    private void Update()
    {
        //Vector3 rotation = Target.position - transform.position;
        //targetB.position = transform.position;
        //targetC.position = transform.position;
        //targetD.position = transform.position;
        //Quaternion direction = Quaternion.LookRotation(rotation);
        //transform.rotation = Quaternion.Lerp(transform.rotation, direction, Speed * Time.deltaTime);
        Vector3 relativePos = Target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

}
