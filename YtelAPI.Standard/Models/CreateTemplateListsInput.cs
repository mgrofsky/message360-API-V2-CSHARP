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
    public class CreateTemplateListsInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type = "authorization";
        private int? page = 1;
        private int? pagesize = 10;
        private string shortcode;

        /// <summary>
        /// The type (category) of template Valid values: marketing, authorization
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The page count to retrieve from the total results in the collection. Page indexing starts at 1.
        /// </summary>
        [JsonProperty("page")]
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
        /// The count of objects to return per page.
        /// </summary>
        [JsonProperty("pagesize")]
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
        /// Only list templates of type
        /// </summary>
        [JsonProperty("Shortcode")]
        public string Shortcode 
        { 
            get 
            {
                return this.shortcode; 
            } 
            set 
            {
                this.shortcode = value;
                onPropertyChanged("Shortcode");
            }
        }
    }
} 