using System.Collections;
using UnityEngine;

public class LoadingScreenScript: MonoBehaviour
{
    public static LoadingScreenScript Instance;

    private SpriteRenderer _sprite;

    private void Awake()
    {
        if(Instance !=null && Instance!= this)
            Destroy(this);
        Instance = this;

        _sprite = GetComponent<SpriteRenderer>();
        DontDestroyOnLoad(this);
    }

    public IEnumerator ShowRoutine()
    {
        Color startClr = _sprite.color;
        Color endClr = startClr;
        endClr.a = 1;
        
        float t = 0;
        while (t<1)
        {
            _sprite.color = Color.Lerp(startClr, endClr, t);
            t += Time.deltaTime * 4;
            yield return null;
        }

        _sprite.color = endClr;
    }

    public IEnumerator FadeRoutine()
    {
        Color startClr = _sprite.color;
        Color endClr = _sprite.color;
        endClr.a = 0;
        
        float t = 0;
        while (t<1)
        {
            _sprite.color = Color.Lerp(startClr, endClr, t);
            t += Time.deltaTime * 4;
            yield return null;
        }
        
        _sprite.color = endClr;
    }
    
}