using NsqSharp;


namespace subscriber{
     public class MessageHandler : IHandler
    {
        

        /// <summary>Handles a message.</summary>
        public void HandleMessage(IMessage message)
        {
            string msg =System.Text.Encoding.UTF8.GetString(message.Body);
            System.Console.WriteLine("Received!!!!! "+msg);

        }

        /// <summary>
        /// Called when a message has exceeded the specified <see cref="Config.MaxAttempts"/>.
        /// </summary>
        /// <param name="message">The failed message.</param>
        public void LogFailedMessage(IMessage message)
        {
            // Log failed messages
        }
    }
}