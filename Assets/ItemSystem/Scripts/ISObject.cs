using UnityEngine;
using System.Collections;
using System;

namespace ItemSystem
{
    [System.Serializable]
    public class ISObject : IISObject
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private string _name;
        [SerializeField] private int _value;
        [SerializeField] private int _burden;
        [SerializeField] private ISQuality _quality;


        public int Burden
        {
            get { return _burden; }
            set { _burden = value; }
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

        public ISQuality Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}