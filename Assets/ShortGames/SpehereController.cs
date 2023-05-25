using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpehereController : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5;

    public Text coinText;
    public int coin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(X,0,Y);

        rb.AddForce(movement * speed);

        coinText.text = "Gold : " + coin.ToString();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin++;
        }
    }
}
