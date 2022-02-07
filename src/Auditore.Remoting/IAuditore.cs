namespace Auditore.Remoting
{
   public interface IAuditoreClient
   {
      bool IsMuted { get; }

      bool Pause { get; set; }

      int Volume { get; set; }

      int TalkSpeed { get; set; }

      int Pitch { get; set; }

      int CurrentTaskId { get; }

      int TaskCount { get; }
      string Version { get; }

      int Push(string text);

      int Push(string text, int talkSpeed);

      int Push(string text, int talkSpeed, int volume);

      void ClaerAll();

      void Reset();

      void Skip();

      void ToggleMute();
   }
}
