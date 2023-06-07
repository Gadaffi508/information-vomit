using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gecis : MonoBehaviour
{
    public static Gecis Instance;
    public float speed = 5f; // Hareket hýzý
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }   
        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Yatay giriþ alýnmasý

        // Hareketin hesaplanmasý
        Vector3 movement = new Vector3(moveInput, 0f, 0f) * speed * Time.deltaTime;

        // Hareketin uygulanmasý
        transform.Translate(movement);
    }

    public void NextScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}
