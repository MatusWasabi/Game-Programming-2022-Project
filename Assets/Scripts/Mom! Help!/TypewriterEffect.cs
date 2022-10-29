using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{

    [SerializeField] private float typeSpeed = 10f;
    //[SerializeField] private float delayTypeSpees = 2f;

    public Coroutine Run(string textToType, TMP_Text textLabel)
    {
        return StartCoroutine(TypeText(textToType, textLabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {
        textLabel.text = string.Empty;  

        //yield return new WaitForSeconds(delayTypeSpees); 

        float t = 0;
        int CharIndex = 0;

        while (CharIndex < textToType.Length)
        {
            t += Time.deltaTime * typeSpeed;
            CharIndex = Mathf.FloorToInt(t);
            CharIndex = Mathf.Clamp(CharIndex, 0, textToType.Length);   

            textLabel.text = textToType.Substring(0, CharIndex);    

            yield return null;  
        }

        textLabel.text = textToType;    
    }

}
