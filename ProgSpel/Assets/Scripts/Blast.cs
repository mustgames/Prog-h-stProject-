using UnityEngine;

public class Blast : MonoBehaviour
{
    public float spd;
    public Rigidbody2D rb;
    public Transform trans;



    void Update()
    {
        void OnTriggerEnter2D ()
        {

        }
        rb.AddForce(new Vector2(0,spd * Time.deltaTime));

        if(trans.position.y > 11.5f)
        {
            Destroy(gameObject);
        }
    }
}
