using UnityEngine;
using UnityEngine.UI;

public class ButtonClickScript : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    
    private void Awake()
    {
        _particleSystem = GetComponentInChildren<ParticleSystem>();
        GetComponent<Button>().onClick.AddListener(()=> OnClick());
    }

    private void OnClick()
    {
        _particleSystem.Play();
        TextScoreScript.Instance.UpdateText();
    }
}
