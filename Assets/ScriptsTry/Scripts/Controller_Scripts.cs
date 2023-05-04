using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Controller_Scripts : MonoBehaviour
{
    public float speed;
    public Text time;
    float timeF;

    [SerializeField] private List<string> name = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.unityLogger.logEnabled = Debug.isDebugBuild; // debug mesaj�n� alt alta g�rmek yerine tek seferde g�rmemizi sa�lar

        name[^1] = " gold "; // son elemana ula�ma kodu
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * -speed * Time.deltaTime);
        timeF += Time.deltaTime;
        time.text = "Time : "+timeF.ToString("00.00");

        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) // eklde�imiz u� lara dokundu�umuz da
            {
                Debug.Log("UI touched");
            }
        }
    }
    [System.Diagnostics.Conditional("UNITY_EDITOR")] //if endif yapmaktansa tek sat�rda bunun ile halledebiliriz
    private void OnApplicationFocus(bool focus) //oyunumuzu alt tab || oyunumuz windows + d yapt���m�zda
    {
        if (!focus)
            SaveGame();
    }
    private void SaveGame()
    {

    }
    private void OnValidate() // bir �ey de�i�ince �al��an fonksiyon
    {
        Debug.Log(timeF);
    }
}
