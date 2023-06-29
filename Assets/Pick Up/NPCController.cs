using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float walkSpeed = 2f;
    public float turnSpeed = 3f;
    public float waitTime = 1f;

    private bool isWalking = false;
    private bool isTurning = false;
    private float turnDirection;
    private float waitTimer;

    private void Start()
    {
        // Ýlk olarak dolaþmaya baþlamak için NPC'yi harekete geçirin
        StartWalking();
    }

    private void Update()
    {
        if (isWalking)
        {
            // NPC yürürken ileri doðru hareket et
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        }

        if (isTurning)
        {
            // NPC, belirli bir süre bekledikten sonra dönüþ hareketine baþlayacak
            waitTimer -= Time.deltaTime;

            if (waitTimer <= 0f)
            {
                isTurning = false;
                StartWalking();
            }
        }
    }

    private void StartWalking()
    {
        isWalking = true;
        isTurning = false;

        // NPC'yi rastgele bir yöne döndürün
        turnDirection = Random.Range(-1f, 1f);
        waitTimer = waitTime;

        // NPC dönüþ yaparken beklesin
        StartCoroutine(TurnAndWait());
    }

    private System.Collections.IEnumerator TurnAndWait()
    {
        // NPC'yi dönüþ yönüne çevirin
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = transform.rotation * Quaternion.Euler(0f, turnDirection * 90f, 0f);

        // Dönüþ hareketini yavaþça gerçekleþtirin
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime * turnSpeed;
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);
            yield return null;
        }

        isWalking = false;
        isTurning = true;
    }
}
