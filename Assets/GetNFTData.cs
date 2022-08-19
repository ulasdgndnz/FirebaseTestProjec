using UnityEngine;
using Firebase.Firestore;

public class GetNFTData : MonoBehaviour
{
    private ListenerRegistration _listenerRegistration;

    [SerializeField] private string _ownerWalletId = "nfts/0x357B2D2bA2f89977731f0c809AE608003754Cf9a";
    
    void Start()
    {
        var firestore = FirebaseFirestore.DefaultInstance;
        _listenerRegistration = firestore.Document(_ownerWalletId).Listen(snapshot =>
        {
            var nftData = snapshot.ConvertTo<NftData>();
            
            print($"Durability: {nftData.Durability}");
            print($"Is Listed: {nftData.IsListed}");
            print($"Item Id: {nftData.ItemId}");
            print($"Owner Wallet Id: {nftData.OwnerWalletId}");
            print($"Type: {nftData.Type}");
        });
    }

    private void OnDestroy() => _listenerRegistration.Stop();
}
