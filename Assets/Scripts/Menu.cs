using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static Menu instance { get; private set; }

    public List<TMP_InputField> inputs;
    public List<string> names;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    public void StartGame()
    {
        foreach(var field in inputs)
        {
            if (!string.IsNullOrEmpty(field.text))
            {
                names.Add(field.text);
            }
        }

        if (names.Count == 3)
        {
            SceneManager.LoadScene("Game");
        }
        else
        {
            names.Clear();
        }
    }
}
