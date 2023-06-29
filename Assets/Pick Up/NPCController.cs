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
        // �lk olarak dola�maya ba�lamak i�in NPC'yi harekete ge�irin
        StartWalking();
    }

    private void Update()
    {
        if (isWalking)
        {
            // NPC y�r�rken ileri do�ru hareket et
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        }

        if (isTurning)
        {
            // NPC, belirli bir s�re bekledikten sonra d�n�� hareketine ba�layacak
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

        // NPC'yi rastgele bir y�ne d�nd�r�n
        turnDirection = Random.Range(-1f, 1f);
        waitTimer = waitTime;

        // NPC d�n�� yaparken beklesin
        StartCoroutine(TurnAndWait());
    }

    private System.Collections.IEnumerator TurnAndWait()
    {
        // NPC'yi d�n�� y�n�ne �evirin
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = transform.rotation * Quaternion.Euler(0f, turnDirection * 90f, 0f);

        // D�n�� hareketini yava��a ger�ekle�tirin
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
