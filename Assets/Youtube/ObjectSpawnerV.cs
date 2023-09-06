using UnityEngine;

public class ObjectSpawnerV : MonoBehaviour
{
    [SerializeField] private float AutoDestroyTime;
    [SerializeField] private bool SpawnFixedUpdate;
    [SerializeField] private UnityEventsV Prefab;

    private int TotalTextDied;

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 20),$"Children Alive : {TotalTextDied : N0}");
    }

    private void Update()
    {
        if (!SpawnFixedUpdate) SpawnObject();
    }

    private void FixedUpdate()
    {
        if (SpawnFixedUpdate) SpawnObject();
    }

    private void SpawnObject()
    {
        UnityEventsV text = Instantiate(
            Prefab,
            new Vector3(Random.Range(0, Screen.width),Random.Range(0, Screen.height),0),Quaternion.identity,transform
            );

        text.AutoDestroyTime = AutoDestroyTime;
        text.OnDeath += HandleTextDeath;
    }

    private void HandleTextDeath(Vector2 Position)
    {
        TotalTextDied++;
    }
}
