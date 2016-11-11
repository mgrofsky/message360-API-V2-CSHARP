/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/11/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;

namespace message360.Models
{
    public class CreateViewTranscriptionInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string transcriptionSid;
        private string responseType = "json";

        /// <summary>
        /// Unique Transcription ID
        /// </summary>
        [JsonProperty("TranscriptionSid")]
        public string TranscriptionSid 
        { 
            get 
            {
                return this.transcriptionSid; 
            } 
            set 
            {
                this.transcriptionSid = value;
                onPropertyChanged("TranscriptionSid");
            }
        }

        /// <summary>
        /// Response format, xml or json
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType 
        { 
            get 
            {
                return this.responseType; 
            } 
            set 
            {
                this.responseType = value;
                onPropertyChanged("ResponseType");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 