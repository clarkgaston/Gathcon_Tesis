using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PointsController : MonoBehaviour
{
    public UnityEvent PointEvent = new UnityEvent();
    public UnityEvent PointLessEvent = new UnityEvent();

    public float velocidad = 5.0f;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-3f, 3f), transform.position.y);
    }

    void Update()
    {

        transform.Translate(Vector3.down * velocidad * Time.deltaTime);

        if (transform.position.y < -1.8)
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), 7.1f);

            PointLessEvent.Invoke();

            if (velocidad < 10)
            {
                velocidad += 0.5f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), 7.1f);


            PointEvent.Invoke();

            if (velocidad < 10)
            {
                velocidad += 0.1f;
            }
        }
    }
}
