﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPPOON_LV6_5
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using(StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(type + ": " + DateTime.Now);
                writer.WriteLine(new string('=', message.Length));
                writer.WriteLine(message);
                writer.WriteLine(new string('=', message.Length) + "\n");
            }
        }
    }
}
