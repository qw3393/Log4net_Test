﻿namespace TTG_LOG_WPF.Logging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using log4net.Appender;
    using System.ComponentModel;
    using System.IO;
    using System.Globalization;
    using log4net;
    using log4net.Core;

    /// <summary>
    /// The appender we are going to bind to for our logging.
    /// </summary>
    public class NotifyAppender : AppenderSkeleton, INotifyPropertyChanged
    {
        #region Members and events
        private static string _notification;
        private event PropertyChangedEventHandler _propertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChanged += value; }
            remove { _propertyChanged -= value; }
        }
        #endregion

        /// <summary>
        /// Get or set the notification message.
        /// </summary>
        public string Notification
        {
            get
            {
                return _notification; ;
            }
            set
            {
                if (_notification != value)
                {
                    _notification = value;
                    OnChange();
                }
            }
        }

        /// <summary>
        /// Raise the change notification.
        /// </summary>
        private void OnChange()
        {
            PropertyChangedEventHandler handler = _propertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(string.Empty));
            }
        }

        /// <summary>
        /// Get a reference to the log instance.
        /// </summary>
        public NotifyAppender Appender
        {
            get
            {
                return Log.Appender;
            }

        }

        /// <summary>
        /// Append the log information to the notification.
        /// </summary>
        /// <param name="loggingEvent">The log event.</param>
        protected override void Append(LoggingEvent loggingEvent)
        {
            StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
            Layout.Format(writer, loggingEvent);
            Notification += writer.ToString();
        }
    }
}
