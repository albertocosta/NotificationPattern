﻿namespace NotiticationApi.Notification
{
    /// <summary>
    /// Classe que representa a mensagem
    /// </summary>
    public class Notification
    {
        public string Key { get; set; }
        public string Message { get; set; }

        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }

    }
}
