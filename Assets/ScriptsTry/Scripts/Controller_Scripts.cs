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
        Debug.unityLogger.logEnabled = Debug.isDebugBuild; // debug mesajýný alt alta görmek yerine tek seferde görmemizi saðlar

        name[^1] = " gold "; // son elemana ulaþma kodu
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * -speed * Time.deltaTime);
        timeF += Time.deltaTime;
        time.text = "Time : "+timeF.ToString("00.00");

        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) // ekldeðimiz uý lara dokunduðumuz da
            {
                Debug.Log("UI touched");
            }
        }
    }
    [System.Diagnostics.Conditional("UNITY_EDITOR")] //if endif yapmaktansa tek satýrda bunun ile halledebiliriz
    private void OnApplicationFocus(bool focus) //oyunumuzu alt tab || oyunumuz windows + d yaptýðýmýzda
    {
        if (!focus)
            SaveGame();
    }
    private void SaveGame()
    {

    }
    private void OnValidate() // bir þey deðiþince çalýþan fonksiyon
    {
        Debug.Log(timeF);
    }
}
