using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ObstacleController : MonoBehaviour
{
    public GameObject botonReinicio, txtMensaje, textoPuntos, player, points;

    int puntos = 0;

    public float velocidad = 5.0f;

    //public Text textoPuntos;

    public PointsController pointsController;

    float timer;

    void Start()
    {
        timer = 0f;

        transform.position = new Vector3(Random.Range(-2f, 2f), transform.position.y);

        pointsController.PointEvent.AddListener(AddPoints);
        pointsController.PointLessEvent.AddListener(LostPoints);
    }

    public void AddPoints()
    {
        puntos += 2;

        textoPuntos.GetComponent<Text>().text = "Puntos: " + puntos;
    }

    public void LostPoints()
    {
        puntos -= 2;

        textoPuntos.GetComponent<Text>().text = "Puntos: " + puntos;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(puntos >= 30)
        {
            botonReinicio.SetActive(true);
            txtMensaje.SetActive(true);
        }

        transform.Translate(Vector3.down * velocidad * Time.deltaTime);

        if (transform.position.y < -1.8)
        {
            transform.position = new Vector3(Random.Range(-2f, 2f), 7.1f);
            puntos++;

            textoPuntos.GetComponent<Text>().text = "Puntos: " + puntos;

            if (velocidad < 10)
            {
                velocidad += 0.1f;
            }
        }
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            transform.position = new Vector3(Random.Range(-2f, 2f), 7.1f);
            puntos--;

            textoPuntos.GetComponent<Text>().text = "Puntos: " + puntos;

            if (velocidad < 10)
            {
                velocidad += 0.5f;
            }
        }
    }
}
