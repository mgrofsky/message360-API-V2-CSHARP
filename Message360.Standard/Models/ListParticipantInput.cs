/*
 * Message360.Standard
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
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
using APIMATIC.SDK.Common;


namespace message360.Models
{
    public class ListParticipantInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string responseType = "json";
        private int? page = 1;
        private int? pagesize = 10;
        private bool? muted;
        private bool? deaf;

        /// <summary>
        /// unique conference sid
        /// </summary>
        [JsonProperty("ConferenceSid")]
        public string ConferenceSid 
        { 
            get 
            {
                return this.conferenceSid; 
            } 
            set 
            {
                this.conferenceSid = value;
                onPropertyChanged("ConferenceSid");
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
        /// page number
        /// </summary>
        [JsonProperty("Page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// Amount of records to return per page
        /// </summary>
        [JsonProperty("Pagesize")]
        public int? Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }

        /// <summary>
        /// Participants that are muted
        /// </summary>
        [JsonProperty("Muted")]
        public bool? Muted 
        { 
            get 
            {
                return this.muted; 
            } 
            set 
            {
                this.muted = value;
                onPropertyChanged("Muted");
            }
        }

        /// <summary>
        /// Participants cant hear
        /// </summary>
        [JsonProperty("Deaf")]
        public bool? Deaf 
        { 
            get 
            {
                return this.deaf; 
            } 
            set 
            {
                this.deaf = value;
                onPropertyChanged("Deaf");
            }
        }
    }
} 