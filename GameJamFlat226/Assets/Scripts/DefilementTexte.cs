using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DefilementTexte : MonoBehaviour
{

    public string[] MonTexte;
    public Text ZoneDeTexte;
    private int _phraseIdx = 0;
    private int _textIdx = 0;
    public string NextLevel;
    public float DelayTime;


    // Use this for initialization
    void Start()
    {
        // ZoneDeTexte.text = MonTexte.ToString();
        ZoneDeTexte.text = "";
        DisplayLetter();
        StartCoroutine(SwitchScene());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && (_textIdx != MonTexte[_phraseIdx].Length))
        {
            DisplayFullPhrase();
        }

        else if ((Input.GetButtonDown("Submit") && (_textIdx == MonTexte[_phraseIdx].Length)))
        {
            NextPhrase();
        }
    }

    void DisplayLetter()
    {
        if (_textIdx <= MonTexte[_phraseIdx].Length - 1)
        {
            ZoneDeTexte.text += MonTexte[_phraseIdx][_textIdx].ToString();
            StartCoroutine("TextWait");
        }
    }

    IEnumerator TextWait()
    {
        yield return new WaitForSeconds(0.05f);
        _textIdx++;
        DisplayLetter();
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(DelayTime);
        SceneManager.LoadScene(NextLevel);
    }

    void NextPhrase()
    {
        _phraseIdx++;
        if (_phraseIdx <= MonTexte.Length - 1)
        {
            _textIdx = 0;
            ZoneDeTexte.text = "";
            DisplayLetter();
        }
        else if (_phraseIdx > MonTexte.Length - 1)
        {
            //NextScene();
        }
    }

    void DisplayFullPhrase()
    {
        StopCoroutine("TextWait");
        _textIdx = MonTexte[_phraseIdx].Length;
        ZoneDeTexte.text = MonTexte[_phraseIdx];
    }
}
