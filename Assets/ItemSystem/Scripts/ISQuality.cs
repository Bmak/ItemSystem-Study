using UnityEngine;
using System.Collections;

namespace ItemSystem
{
    [System.Serializable]
    public class ISQuality : IISQuality
    {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _icon;

        public ISQuality()
        {
            _name = "";
            _icon = new Sprite();
        }

        public ISQuality(string name, Sprite icon)
        {
            _name = name;
            _icon = icon;
        }

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}