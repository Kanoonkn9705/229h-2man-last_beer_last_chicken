using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject endGameUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            endGameUI.SetActive(true); // แสดง UI
            Time.timeScale = 0f;       // หยุดเวลา (หยุดเกม)
        }
    }
}
