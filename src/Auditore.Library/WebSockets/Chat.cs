
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Auditore.Library.WebSockets
{
   public class Chat : WebSocketBehavior
   {
      protected override void OnMessage(MessageEventArgs e)
      {
         Sessions.Broadcast(e.Data);
      }
   }
}
