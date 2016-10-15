/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/15/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum HttpMethodEnum
    {
        GET, //Get type
        POST, //Post Type
    }

    /// <summary>
    /// Helper for the enum type HttpMethodEnum
    /// </summary>
    public static class HttpMethodEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "GET", "POST" };

        /// <summary>
        /// Converts a HttpMethodEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The HttpMethodEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(HttpMethodEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case HttpMethodEnum.GET:
                case HttpMethodEnum.POST:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of HttpMethodEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of HttpMethodEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<HttpMethodEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into HttpMethodEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed HttpMethodEnum value</returns>
        public static HttpMethodEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type HttpMethodEnum", value));

            return (HttpMethodEnum) index;
        }
    }
} 