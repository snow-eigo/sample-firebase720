using UnityEngine;
using UnityEngine.UI;

public class MessagingSubscriber : MonoBehaviour
{

   public Text tokenText;
   public Text messageText;
     
     

   private void Start() 
   {
      Firebase.Messaging.FirebaseMessaging.TokenReceived += OnTokenReceived;
      Firebase.Messaging.FirebaseMessaging.MessageReceived += OnMessageReceived;
   }

   private void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token)
   {
      tokenText.text = token.Token;
      Debug.Log("Received Registration Token: " + token.Token);
   }

   private void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e)
   {
      messageText.text = e.Message.From;
      Debug.Log("Received a new message from: " + e.Message.From);
   }
}
