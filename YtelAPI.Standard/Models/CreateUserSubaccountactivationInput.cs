/*
 * YtelAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities;


namespace YtelAPI.Standard.Models
{
    public class CreateUserSubaccountactivationInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string subAccountSID;
        private Models.MActivateEnum mActivate;

        /// <summary>
        /// The SubaccountSid to be activated or suspended
        /// </summary>
        [JsonProperty("SubAccountSID")]
        public string SubAccountSID 
        { 
            get 
            {
                return this.subAccountSID; 
            } 
            set 
            {
                this.subAccountSID = value;
                onPropertyChanged("SubAccountSID");
            }
        }

        /// <summary>
        /// 0 to suspend or 1 to activate
        /// </summary>
        [JsonProperty("mActivate")]
        public Models.MActivateEnum MActivate 
        { 
            get 
            {
                return this.mActivate; 
            } 
            set 
            {
                this.mActivate = value;
                onPropertyChanged("MActivate");
            }
        }
    }
} 