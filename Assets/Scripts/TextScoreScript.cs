using TMPro;
using UnityEngine;

public class TextScoreScript : MonoBehaviour
{
    public static TextScoreScript Instance;

    private static int _score;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        if(Instance !=null && Instance!= this)
            Destroy(this);
        Instance = this;
        
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = "--- " + _score + " ---";
    }

    public void UpdateText()
    {
        _score++;
        _text.text = "--- " + _score + " ---";
    }
}
