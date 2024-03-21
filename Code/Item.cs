using System;
using _Project.Common.ItemSystem.Database;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Project.Common.ItemSystem
{
    [CreateAssetMenu(fileName = "New_Item", menuName = "ItemSystem/Create Item")]
    public class Item : ScriptableObject, ICollectible
    {
        [SerializeField, InlineEditor] private ItemData _itemData;
        [SerializeField] private int _itemCount = 1;


        public event Action<int> ItemCountChanged;

        public ItemData Data => _itemData;

        public int Count
        {
            get => _itemCount;
            private set
            {
                _itemCount = value;
                ItemCountChanged?.Invoke(value);
            }
        }

        public void Collect()
        {
            if (_itemData.Stackable) Count++;

            //Add to inventory...
        }

        public void Use()
        {
            //Use..
        }

        public void Discard()
        {
            //Discard...
        }
    }
}