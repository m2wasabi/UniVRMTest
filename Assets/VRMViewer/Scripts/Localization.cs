﻿using UnityEngine;
using UnityEngine.UI;
using VRM;

namespace VRMViewer
{
    public class Localization : MonoBehaviour
    {
        [SerializeField]
        [TextArea]
        public string Japnaese = "日本語";

        [SerializeField]
        [TextArea]
        public string English = "English";

        [SerializeField]
        [TextArea]
        public string Chinese = "中文";

        [SerializeField]
        private Text _text;

        private void Reset()
        {
            _text = GetComponent<Text>();
        }

        public void SetLanguage(LANGUAGES languages)
        {
            switch (languages)
            {
                case LANGUAGES.Japanese:
                    _text.text = Japnaese;
                    break;
                case LANGUAGES.English:
                    _text.text = English;
                    break;
                case LANGUAGES.Chinese:
                    _text.text = Chinese;
                    break;
            }
        }
    }
}