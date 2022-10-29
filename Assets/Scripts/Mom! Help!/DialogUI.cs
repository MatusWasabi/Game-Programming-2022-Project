using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject dialogueOBJ;

    private TypewriterEffect typewriterEffect;

    private void Start()
    {
       // GetComponent<TypewriterEffect>().Run("WOOOOOOOOOOOOO", m_Text);
        typewriterEffect = GetComponent<TypewriterEffect>();
        CloseDialogue();    
        ShowDialogue(dialogueOBJ);
    }

    private void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);   
        StartCoroutine(StepTrroughDialogue(dialogueObject));
    }

    private IEnumerator StepTrroughDialogue(DialogueObject dialogueObject)
    {
        
        foreach(string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitForSeconds(2);
            //yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }

        CloseDialogue();
    }

    private void CloseDialogue()
    {
        dialogueBox.SetActive(false);
        textLabel.text = String.Empty;
    }
}
