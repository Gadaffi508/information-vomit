using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UnityEventsV : MonoBehaviour
{
    public float AutoDestroyTime;

    private TextMeshProUGUI text;
    private float spawnTime;

    public delegate void DeathEvent(Vector2 Position);
    public DeathEvent OnDeath;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        float remainingTime = (spawnTime + AutoDestroyTime) - Time.time;

        text.SetText($"{remainingTime}:N2");

        if (remainingTime <= 0)
        {
            OnDeath?.Invoke(transform.position);
            Destroy(gameObject);
        }
    }
}
