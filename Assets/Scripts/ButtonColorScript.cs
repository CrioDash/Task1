using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ButtonColorScript:MonoBehaviour
{
    private Image _img;
        
    private void Awake()
    {
        _img = GetComponent<Image>();
        GetComponentInChildren<Button>().onClick.AddListener(()=> _img.color = Random.ColorHSV());
    }
        
}