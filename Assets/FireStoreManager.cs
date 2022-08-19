using System;
using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Firestore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FireStoreManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField _durability;
    [SerializeField] private TMP_InputField _isListed;
    [SerializeField] private TMP_InputField _itemId;
    [SerializeField] private TMP_InputField _ownerWalletId;
    [SerializeField] private TMP_InputField _type;

    [SerializeField] private Button submitButton;

    private ListenerRegistration _listenerRegistration;
    void Start()
    {
        submitButton.onClick.AddListener(() =>
        {
            var nftData = new NftData
            {
                Durability = int.Parse(_durability.text),
                IsListed = bool.Parse(_isListed.text),
                ItemId = _itemId.text,
                OwnerWalletId = _ownerWalletId.text,
                Type = _type.text
            };
            var firestore = FirebaseFirestore.DefaultInstance;
            firestore.Document($"nfts/{_ownerWalletId.text}").SetAsync(nftData);
        });
        
        //print(int.Parse(_durability.text));

    }
}
