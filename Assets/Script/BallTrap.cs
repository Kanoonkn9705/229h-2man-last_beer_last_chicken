using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTrap : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // โหลดซีนเดิม (รีสตาร์ทเกม)
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
