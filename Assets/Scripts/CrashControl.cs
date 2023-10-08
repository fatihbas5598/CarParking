using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashControl : MonoBehaviour
{
    public GameObject lostPanel;

    public AudioSource carCrashed;

    private void Start()
    {
        carCrashed = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Debug.Log("Crashed!");
            lostPanel.SetActive(true);
            Time.timeScale = 0f;
            carCrashed.Play();
        }
    }
}
