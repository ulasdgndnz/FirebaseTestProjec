using Firebase.Firestore;

[FirestoreData]
public struct NftData
{
    [FirestoreProperty]
    public int Durability { get; set; }
    
    [FirestoreProperty]
    public bool IsListed { get; set; }
    
    [FirestoreProperty]
    public string ItemId { get; set; }
    
    [FirestoreProperty]
    public string OwnerWalletId { get; set; }
    
    [FirestoreProperty]
    public string Type { get; set; }
    
}
