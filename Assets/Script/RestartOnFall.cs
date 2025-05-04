using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    public float lowerBound = -10f;  // ถ้าต่ำกว่านี้ = ตก
    public float upperBound = 20f;   // ถ้าสูงกว่านี้ = เด้งหลุด

    void Update()
    {
        float yPos = transform.position.y;

        if (yPos < lowerBound || yPos > upperBound)
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
