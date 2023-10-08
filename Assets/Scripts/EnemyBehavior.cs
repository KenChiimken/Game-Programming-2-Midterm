using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyBehavior : MonoBehaviour

{
    public Transform Target;
    public float Speed = 0.0f;
    public float Health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BulletRed"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.CompareTag("BulletGreen"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        if (other.CompareTag("BulletBlue"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
