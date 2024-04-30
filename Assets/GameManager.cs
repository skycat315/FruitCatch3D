using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // リトライ処理
    public void Retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
