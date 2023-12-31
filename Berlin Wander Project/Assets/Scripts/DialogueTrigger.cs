using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public TextMeshProUGUI text;

    public void TriggerDialogue()
    {
        FindObjectOfType <DialogueManager>().StartDialogue(dialogue);
    }

    public void HideText()
    {
        text.enabled = false;
    }
}
