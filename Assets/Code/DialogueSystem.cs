using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueSystem : MonoSingleton<DialogueSystem>
{
	[Header("Text Variables")]
	public TMP_Text nameText;
	public TMP_Text	 dialogueText;

	[Header("Variables")]
	public float scrollSpeed;
	public float fadeDuration;
	public GameObject Button;
	private Queue<string> sentences;

	// Use this for initialization
	void Awake()
	{
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue)
	{

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence, Action action = null)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return new WaitForSeconds(scrollSpeed);
		}

	}

	void EndDialogue()
	{
		StartCoroutine(UpdateTextColor());
	}

	IEnumerator UpdateTextColor()
	{

		float t = 0;
        while (t < 1)
        {
			dialogueText.color = Color.Lerp(new Color(1f, 1f, 1f, 1f), new Color(1f, 1f, 1f, 0f), t);
			t += Time.deltaTime / fadeDuration;
			Button.SetActive(false);
			yield return new WaitForEndOfFrame();
		}
	}
}
