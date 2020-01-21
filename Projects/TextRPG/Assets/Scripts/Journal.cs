using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TextRPG
{
    public class Journal : MonoBehaviour
    {
        [SerializeField] Text logText;
        public static Journal Instance { get; set; }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }

            logText.supportRichText = true;
        }

        public void Log(string text)
        {
            logText.text += "\n" + text;
        }
    }
}
